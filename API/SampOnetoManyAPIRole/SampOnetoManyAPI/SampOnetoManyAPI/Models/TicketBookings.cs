using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBooking.Models
{
    public class TicketBookings
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        
        [ForeignKey(nameof(MovieDetails))]
        public int MovieId { get; set; }

        [ForeignKey(nameof(screening_schedule))]
        public int ScreenId { get; set; }
 
        [Required]
        public int Count { get; set; }

        [ForeignKey(nameof(Seat))]
        public string? SeatId { get; set; }
        
        public float Cash { get; set; } 

    }
}