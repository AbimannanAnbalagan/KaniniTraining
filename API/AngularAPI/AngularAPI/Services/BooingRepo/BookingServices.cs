using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAPI.Services.BooingRepo
{
    public class BookingServices : IBooking
    {
        private readonly AngularApiContext _context;

        public BookingServices(AngularApiContext context)
        {
            _context = context;
        }

        public async Task<List<Booking>> PostBooking(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
            return await _context.Bookings.ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }
    }
}
