using Microsoft.EntityFrameworkCore;

namespace XYZHotelManagementSystem.Authentication
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }
    }
}
