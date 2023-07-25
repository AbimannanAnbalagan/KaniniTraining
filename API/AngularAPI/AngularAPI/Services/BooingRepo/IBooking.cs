using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularAPI.Services.BooingRepo
{
    public interface IBooking
    {
        Task<ActionResult<IEnumerable<Booking>>> GetBookings();
        Task<List<Booking>> PostBooking(Booking booking);
    }
}
