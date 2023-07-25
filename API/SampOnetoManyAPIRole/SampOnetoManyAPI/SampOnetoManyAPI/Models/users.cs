using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace MovieTicketBooking.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; } = "";

        [Required]
        public string EmailId { get; set; } = "";

        [Required]
        public string Password { get; set; } = string.Empty;
        public ICollection<TicketBookings>? UticketBookings { get; set; } 
    }
}
