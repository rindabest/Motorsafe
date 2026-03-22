using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotorSafe.Backend.Data;
using MotorSafe.Backend.Models;
using System.Security.Claims;

namespace MotorSafe.Backend.Controllers
{
    [ApiController]
    [Route("api/reviews")]
    public class ReviewController : ControllerBase
    {
        private readonly MotorSafeDbContext _context;

        public ReviewController(MotorSafeDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [AllowAnonymous] // Allow demo app without auth token for reviews easily
        public async Task<IActionResult> CreateReview([FromBody] CreateReviewRequest request)
        {
            if (request.Rating < 1 || request.Rating > 5)
            {
                return BadRequest(new { success = false, message = "Rating must be between 1 and 5." });
            }

            var mechanic = await _context.Mechanics.FindAsync(request.MechanicId);
            if (mechanic == null)
            {
                return NotFound(new { success = false, message = "Mechanic not found." });
            }

            // Check duplicate
            var existingReview = await _context.Reviews
                .FirstOrDefaultAsync(r => r.BookingId == request.BookingId);
                
            if (existingReview != null)
            {
                return BadRequest(new { success = false, message = "This booking has already been reviewed." });
            }

            var review = new Review
            {
                MechanicId = request.MechanicId,
                BookingId = request.BookingId,
                Rating = request.Rating,
                Comment = request.Comment ?? string.Empty,
                CreatedAt = DateTime.Now
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            // Treat the current mechanic.Rating as an average of 10 prior votes for stability
            // so a single 1-star review doesn't completely overwrite a 4.0 rating to 1.0!
            double averageRating = Math.Round(((mechanic.Rating * 10) + request.Rating) / 11.0, 1);

            mechanic.Rating = averageRating;
            await _context.SaveChangesAsync();

            // Calculate total reviews (just showing new ones + 10 base)
            var totalCount = await _context.Reviews.CountAsync(r => r.MechanicId == request.MechanicId) + 10;

            return Ok(new
            {
                success = true,
                review = new
                {
                    review.Id,
                    review.MechanicId,
                    review.BookingId,
                    review.Rating,
                    review.Comment,
                    review.CreatedAt
                },
                mechanicAverageRating = averageRating,
                totalReviews = totalCount
            });
        }

        [HttpGet("mechanic/{mechanicId:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetMechanicReviews(int mechanicId)
        {
            var reviews = await _context.Reviews
                .Where(r => r.MechanicId == mechanicId)
                .OrderByDescending(r => r.CreatedAt)
                .Select(r => new
                {
                    r.Id,
                    r.Rating,
                    r.Comment,
                    r.CreatedAt
                })
                .ToListAsync();

            return Ok(new { success = true, reviews, total = reviews.Count });
        }
    }

    public class CreateReviewRequest
    {
        public int MechanicId { get; set; }
        public int BookingId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
