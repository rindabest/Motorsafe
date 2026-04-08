using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotorSafe.Backend.Data;
using MotorSafe.Backend.Models;
using System.Security.Claims;

namespace MotorSafe.Backend.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    [Authorize]
    public class BookingController : ControllerBase
    {
        private readonly MotorSafeDbContext _context;

        public BookingController(MotorSafeDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingRequest request)
        {
            var customerIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(customerIdStr, out int customerId))
                return Unauthorized();

            var booking = new Booking
            {
                CustomerId = customerId,
                MechanicId = null,
                IssueType = request.IssueType,
                LocationLat = request.LocationLat,
                LocationLng = request.LocationLng,
                LocationAddress = request.LocationAddress,
                FinalPrice = 0,
                Status = "Pending"
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, bookingId = booking.Id });
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetBookingHistory()
        {
            var customerIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(customerIdStr, out int customerId))
                return Unauthorized();

            var history = await _context.Bookings
                .Where(b => b.CustomerId == customerId)
                .OrderByDescending(b => b.Id)
                .Select(b => new
                {
                    id = b.Id,
                    status = b.Status,
                    problem = b.IssueType,
                    service_type = b.IssueType,
                    location = b.LocationAddress,
                    created_at = b.CreatedAt,
                    updated_at = b.CreatedAt
                })
                .ToListAsync();

            return Ok(history);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _context.Bookings
                .Include(b => b.Mechanic)
                .Select(b => new
                {
                    b.Id,
                    b.MechanicId,
                    b.Status,
                    b.IssueType,
                    b.FinalPrice,
                    MechanicName = b.Mechanic != null ? b.Mechanic.Name : null,
                    MechanicPhone = b.Mechanic != null ? b.Mechanic.Phone : null,
                    b.LocationLat,
                    b.LocationLng,
                    IsReviewed = _context.Reviews.Any(r => r.BookingId == b.Id)
                })
                .FirstOrDefaultAsync(b => b.Id == id);

            if (booking == null)
                return NotFound();

            return Ok(new { success = true, booking });
        }

        [HttpPut("{id}/assign-mechanic")]
        public async Task<IActionResult> AssignMechanic(int id, [FromBody] AssignMechanicRequest request)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var booking = await _context.Bookings.FindAsync(id);
                if (booking == null) return NotFound();

                // Row-level lock to prevent race condition (MySQL InnoDB)
                var mechanic = await _context.Mechanics
                    .FromSqlRaw("SELECT * FROM mechanics WHERE Id = {0} FOR UPDATE", request.MechanicId)
                    .FirstOrDefaultAsync();

                if (mechanic == null || !mechanic.IsAvailable)
                    return BadRequest(new { message = "Thợ này đã được chọn bởi người khác." });

                // Mark mechanic as unavailable
                mechanic.IsAvailable = false;

                booking.MechanicId = request.MechanicId;
                booking.FinalPrice = request.FinalPrice;
                booking.Status = "Pending";

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Ok(new { success = true });
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                return Conflict(new { message = "Có lỗi xảy ra, vui lòng thử lại." });
            }
        }

        [HttpPut("{id}/simulate-status")]
        [AllowAnonymous] // Allow frontend to blindly hit this for demo
        public async Task<IActionResult> SimulateStatus(int id, [FromBody] SimulateStatusRequest request)
        {
            var booking = await _context.Bookings
                .Include(b => b.Mechanic)
                .FirstOrDefaultAsync(b => b.Id == id);
            if (booking == null) return NotFound();

            booking.Status = request.Status;
            
            if (request.Status == "Completed")
            {
                booking.CompletedAt = DateTime.UtcNow.AddHours(7);
                // Release mechanic
                if (booking.Mechanic != null)
                    booking.Mechanic.IsAvailable = true;
            }

            if (request.Status == "Cancelled")
            {
                // Release mechanic
                if (booking.Mechanic != null)
                    booking.Mechanic.IsAvailable = true;
            }

            await _context.SaveChangesAsync();

            return Ok(new { success = true, newStatus = booking.Status });
        }

        [HttpGet("nearest")]
        [AllowAnonymous] // Allow frontend to call this during "finding" phase
        public async Task<IActionResult> GetNearestMechanics([FromQuery] double lat, [FromQuery] double lng, [FromQuery] string issueType)
        {
            var mechanics = await _context.Mechanics
                .Where(m => m.IsAvailable)
                .ToListAsync();

            var allNearby = mechanics.Select(m =>
            {
                var distance = CalculateDistance(lat, lng, m.Latitude, m.Longitude);
                var travelFee = Math.Round((decimal)(distance * 2500)); // 2500k per km

                decimal baseServicePrice = issueType switch
                {
                    "Vá ruột/thay ruột" => 50000,
                    "Đứt xích/đứt dây ga" => 70000,
                    "Kẹt phanh" => 40000,
                    "Kích bình" => 60000,
                    "Bơm hơi" => 10000,
                    "Hết xăng" => 25000,
                    _ => 50000
                };

                var random = new Random();
                decimal laborCost = (issueType == "Bơm hơi" || issueType == "Hết xăng")
                    ? random.Next(10000, 20000)
                    : random.Next(20000, 50000);

                return new
                {
                    m.Id,
                    m.Name,
                    m.ShopName,
                    m.Phone,
                    m.Address,
                    m.Rating,
                    m.Role,
                    LocationLat = m.Latitude,
                    LocationLng = m.Longitude,
                    m.SpecialSkills,
                    DistanceKm = Math.Round(distance, 2),
                    BaseServicePrice = baseServicePrice,
                    TravelFee = travelFee,
                    LaborCost = laborCost,
                    EstimatedPrice = baseServicePrice + travelFee + laborCost
                };
            })
            .Where(m => m.DistanceKm <= 20) // Search within 20km
            .OrderBy(m => m.DistanceKm)
            .ToList();

            IEnumerable<object> result;

            if (issueType == "Bơm hơi" || issueType == "Hết xăng")
            {
                var communityHelpers = allNearby.Where(m => m.Role == "CommunityHelper").Take(4);
                var mechanicsOnly = allNearby.Where(m => m.Role == "Mechanic").Take(1);
                result = communityHelpers.Concat(mechanicsOnly).OrderBy(m => ((dynamic)m).DistanceKm);
            }
            else
            {
                result = allNearby.Where(m => m.Role == "Mechanic").Take(5);
            }

            return Ok(new { success = true, mechanics = result.ToList() });
        }

        private static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            var r = 6371; // km
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return r * c;
        }

        private static double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }
    }

    public class CreateBookingRequest
    {
        public string IssueType { get; set; } = string.Empty;
        public double LocationLat { get; set; }
        public double LocationLng { get; set; }
        public string LocationAddress { get; set; } = string.Empty;
    }

    public class SimulateStatusRequest
    {
        public string Status { get; set; } = string.Empty;
    }

    public class AssignMechanicRequest
    {
        public int MechanicId { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
