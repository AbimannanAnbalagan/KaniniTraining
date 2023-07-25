using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XYZHotelManagementSystem.Models;

namespace XYZHotelManagementSystem.Repository.Rooms
{
    public class RoomServices : IRoomServices
    {
        private readonly FinalDbContext _context;

        public RoomServices(FinalDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Room>>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<ActionResult<List<Room>>> GetRoom(int Hotelid)
        {
            var det = await (from s in _context.Rooms where s.HotelId == Hotelid select s).ToListAsync();
            return det;
        }

        public async Task<ActionResult<List<Room>>> PutRoom(int Roomid, Room room)
        {
            
            var det = await _context.Rooms.FindAsync(Roomid);
            if (det == null)
            {
                throw new Exception("No matches");
            }
            det.AvalabilityStatus = room.AvalabilityStatus;
            det.price = room.price;
            det.RoomNumber = room.RoomNumber;

            await _context.SaveChangesAsync();
            return _context.Rooms.Where(x=>x.RoomId == room.RoomId).ToList();

        }

        public async Task<string> DeleteRoom(int id)
        {
            var det = await _context.Rooms.FindAsync(id);
            if (det == null)
            {
                throw new Exception("no matches");
            }
            _context.Rooms.Remove(det);
            await _context.SaveChangesAsync();
            return $"Details of {det.RoomId} Hotel is deleted Successfully";
        }

        public async Task<String> PostRoom(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
            return "Row Added Successfully";
        }
    }
}
