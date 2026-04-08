using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorSafe.Backend.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int MechanicId { get; set; }
        public Mechanic Mechanic { get; set; } = null!;

        public int BookingId { get; set; }
        public Booking Booking { get; set; } = null!;

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(7);
    }
}
