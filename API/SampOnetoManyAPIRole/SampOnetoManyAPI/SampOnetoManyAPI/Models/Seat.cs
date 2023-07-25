using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBooking.Models
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SeatId { get; set; } = string.Empty;

        [ForeignKey(nameof(screening_schedule))]
        public int ScreenId { get; set; }
        
        [Required]
        public string Status { get; set; } = string.Empty; 

        public ICollection<TicketBookings>? SEATticketBookings { get; set; }
    }
}