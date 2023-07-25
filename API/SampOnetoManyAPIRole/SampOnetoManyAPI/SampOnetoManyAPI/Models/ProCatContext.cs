using Microsoft.EntityFrameworkCore;
using MovieTicketBooking.Models;

namespace SampOnetoManyAPI.Models
{
    public class ProCatContext : DbContext
    {

        public DbSet<Users> Users { get; set; }

        public DbSet<MovieDetails> MoviesDetails { get; set; }

        public DbSet<screening_schedule> ScreeningSchedules { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<TicketBookings> ticketBookings { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> User { get; set; }

        public ProCatContext(DbContextOptions<ProCatContext> options) : base(options) 
        { 

        }
    }
}
