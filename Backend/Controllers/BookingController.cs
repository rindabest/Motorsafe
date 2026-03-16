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

            var mechanic = await _context.Mechanics.FindAsync(request.MechanicId);
            if (mechanic == null || !mechanic.IsAvailable)
                return BadRequest(new { message = "Mechanic is not available." });

            var booking = new Booking
            {
                CustomerId = customerId,
                MechanicId = request.MechanicId,
                IssueType = request.IssueType,
                LocationLat = request.LocationLat,
                LocationLng = request.LocationLng,
                LocationAddress = request.LocationAddress,
                FinalPrice = request.FinalPrice,
                Status = "Pending"
            };

            _context.Bookings.Add(booking);
            
            // To prevent double booking easily for simulation, we could mark mechanic as unavailable
            // mechanic.IsAvailable = false;
            
            await _context.SaveChangesAsync();

            return Ok(new { success = true, bookingId = booking.Id });
        }

        [HttpGet("nearest")]
        [Authorize]
        public async Task<IActionResult> GetNearestMechanics(
            [FromQuery] double lat, 
            [FromQuery] double lng, 
            [FromQuery] string issueType = "")
        {
            var mechanicRole = (issueType == "Bơm hơi" || issueType == "Hết xăng") 
                ? "CommunityHelper" 
                : "Mechanic";

            var mechanics = await _context.Mechanics
                .Where(m => m.IsAvailable && m.Role == mechanicRole)
                .ToListAsync();

            // Base service price depending on issue type
            var baseServicePrice = issueType switch
            {
                "Vá ruột/thay ruột" => 50000m,
                "Đứt xích/đứt dây ga" => 40000m,
                "Kẹt phanh" => 30000m,
                "Kích bình" => 60000m,
                "Bơm hơi" => 20000m,
                "Hết xăng" => 20000m,
                _ => 50000m
            };

            var random = new Random();
            var nearest = mechanics
                .Select(m => {
                    var distanceKm = CalculateDistance(lat, lng, m.Latitude, m.Longitude);
                    var travelFee = (decimal)distanceKm * 2000m; // 2k VND per km
                    var laborCost = random.Next(10, 51) * 1000m; // Random 10k-50k VND
                    var estimatedPrice = baseServicePrice + travelFee + laborCost;
                    return new {
                        m.Id,
                        m.Name,
                        m.ShopName,
                        m.Phone,
                        m.Address,
                        m.Rating,
                        m.SpecialSkills,
                        LocationLat = m.Latitude,
                        LocationLng = m.Longitude,
                        DistanceKm = Math.Round(distanceKm, 2),
                        EstimatedPrice = Math.Round(estimatedPrice, 0),
                        BaseServicePrice = baseServicePrice,
                        TravelFee = Math.Round(travelFee, 0),
                        LaborCost = laborCost
                    };
                })
                .OrderBy(m => m.DistanceKm)
                .Take(5)
                .ToList();

            return Ok(new { success = true, mechanics = nearest });
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
                    b.Status,
                    b.IssueType,
                    b.FinalPrice,
                    MechanicName = b.Mechanic.Name,
                    MechanicPhone = b.Mechanic.Phone,
                    b.LocationLat,
                    b.LocationLng
                })
                .FirstOrDefaultAsync(b => b.Id == id);

            if (booking == null)
                return NotFound();

            return Ok(new { success = true, booking });
        }

        [HttpPut("{id}/simulate-status")]
        [AllowAnonymous] // Allow frontend to blindly hit this for demo
        public async Task<IActionResult> SimulateStatus(int id, [FromBody] SimulateStatusRequest request)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            booking.Status = request.Status;
            
            if (request.Status == "Completed")
            {
                booking.CompletedAt = DateTime.Now;
            }

            await _context.SaveChangesAsync();

            return Ok(new { success = true, newStatus = booking.Status });
        }

        [HttpPut("{id}/assign-mechanic")]
        [Authorize]
        public async Task<IActionResult> AssignMechanic(int id, [FromBody] AssignMechanicRequest request)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            var mechanic = await _context.Mechanics.FindAsync(request.MechanicId);
            if (mechanic == null || !mechanic.IsAvailable)
                return BadRequest(new { message = "Mechanic is not available." });

            booking.MechanicId = request.MechanicId;
            booking.FinalPrice = request.FinalPrice;

            await _context.SaveChangesAsync();

            return Ok(new { success = true, mechanicName = mechanic.Name });
        }
    }

    public class CreateBookingRequest
    {
        public int MechanicId { get; set; }
        public string IssueType { get; set; } = string.Empty;
        public double LocationLat { get; set; }
        public double LocationLng { get; set; }
        public string LocationAddress { get; set; } = string.Empty;
        public decimal FinalPrice { get; set; }
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
