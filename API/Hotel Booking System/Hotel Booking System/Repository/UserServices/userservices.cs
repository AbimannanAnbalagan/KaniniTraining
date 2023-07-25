using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Repository.UserServices
{
    public class Userservices : Iuserservices
    {
        private readonly FinalDbContext _context;
        public Userservices(FinalDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUsers()
        {
            var cus = await _context.users.ToListAsync();
            return cus;
        }
    }
}
