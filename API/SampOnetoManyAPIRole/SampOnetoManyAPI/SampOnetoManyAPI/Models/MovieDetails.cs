using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MovieTicketBooking.Models
{
    public class MovieDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        [Required]
        public string MovieTitle { get; set; } = string.Empty;

        [Required]
        public string MovieGenre { get; set;} = string.Empty;

        [Required]
        public float Cost { get; set;}

        [Required]
        public string? ReleasedDate { get; set; }
        
        public string? DroppedDate { get; set; }

        public ICollection<TicketBookings>? MticketBookings { get; set;}
    }
}
