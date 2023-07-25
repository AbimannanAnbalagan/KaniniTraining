using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBooking.Models
{
    public class screening_schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ScreenId { get; set; }

        public string ScreenTimings { get; set; } = string.Empty;

        //[ForeignKey(nameof(MovieDetails))]
       // public int MovieId { get; set; }

        [ForeignKey("MovieDetails")]
        public int MovieId { get; set; }
        public virtual MovieDetails? MovieDetails { get; set; }

        public ICollection<MovieDetails>? SmovieDetails { get; set;}

        public ICollection<TicketBookings>? SticketBookings { get; set; }
    }
}
