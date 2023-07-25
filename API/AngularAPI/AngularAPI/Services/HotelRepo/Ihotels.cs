using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularAPI.Services.HotelRepo
{
    public interface Ihotels
    {
        Task<List<Hotel>> GetHotels();

        Task<ActionResult<IEnumerable<Hotel>>> GetHotelsByLocation(string location);

        Task<ActionResult<List<Hotel>>> GetHotelsById(int id);

        Task<List<Hotel>> PostHotel(Hotel hotel);

        Task<List<Hotel>> PutHotel(int id, Hotel hotel);

        Task<List<Hotel>> DeleteHotel(int id);
    }

}
