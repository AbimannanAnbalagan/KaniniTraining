using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAPI.Services.HotelRepo
{
    public class HotelServices : Ihotels
    {
        private readonly AngularApiContext _context;

        public HotelServices(AngularApiContext context)
        {
            _context = context;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        /*public async Task<List<Hotel>> GetHotel(string location, int id, Hotel hotel)
        {
            //var det= await _context.Hotels.FirstOrDefaultAsync(x => x.HotelId == id);
            var det = await (from h in _context.Hotels where h.Location == location select h).ToListAsync();
            //var det = await _context.Hotels.FindAsync(location);
            return det;
        }*/

        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelsByLocation(string location)
        {
            var hotels = await _context.Hotels
            .Where(h => h.Location == location)
            .ToListAsync();

            return hotels;
        }

        public async Task<ActionResult<List<Hotel>>> GetHotelsById(int id)
        {
            var hotels = await _context.Hotels.Where(h=> h.HotelId== id).ToListAsync();
            return hotels;
        }

        public async Task<List<Hotel>> PostHotel(Hotel hotel)
        {
            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return await _context.Hotels.ToListAsync();
        }

        public async Task<List<Hotel>> PutHotel(int id, Hotel hotel)
        {
            var sd = await _context.Hotels.FirstOrDefaultAsync(x => x.HotelId == id);
            sd.HotelName = hotel.HotelName;
            sd.Location = hotel.Location;
            await _context.SaveChangesAsync();
            return await _context.Hotels.Where(x => x.HotelId == id).ToListAsync();
        }

        public async Task<List<Hotel>> DeleteHotel(int id)
        {
            var det = await _context.Hotels.FindAsync(id);
            if (det == null)
            {
                throw new Exception("No matches");
            }
            _context.Hotels.Remove(det);
            await _context.SaveChangesAsync();
            return await _context.Hotels.ToListAsync();
        }
    }
}
