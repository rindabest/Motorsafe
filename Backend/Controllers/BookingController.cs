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

        [HttpPut("{id}/assign-mechanic")]
        public async Task<IActionResult> AssignMechanic(int id, [FromBody] AssignMechanicRequest request)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            var mechanic = await _context.Mechanics.FindAsync(request.MechanicId);
            if (mechanic == null || !mechanic.IsAvailable)
                return BadRequest(new { message = "Mechanic is no longer available." });

            booking.MechanicId = request.MechanicId;
            booking.FinalPrice = request.FinalPrice;
            booking.Status = "Moving";

            await _context.SaveChangesAsync();

            return Ok(new { success = true });
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

        [HttpGet("nearest")]
        [AllowAnonymous] // Allow frontend to call this during "finding" phase
        public async Task<IActionResult> GetNearestMechanics([FromQuery] double lat, [FromQuery] double lng, [FromQuery] string issueType)
        {
            var mechanics = await _context.Mechanics
                .Where(m => m.IsAvailable)
                .ToListAsync();

            var nearby = mechanics.Select(m =>
            {
                var distance = CalculateDistance(lat, lng, m.Latitude, m.Longitude);
                var travelFee = Math.Round((decimal)(distance * 10000)); // 10k per km

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
            .Take(5)
            .ToList();

            return Ok(new { success = true, mechanics = nearby });
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
