using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Repository.HotelServices
{
    
    public interface IHotelServices 
    {
        Task<string> PostHotels(Hotels hotels);

        Task<List<Hotels>> GetHotels();

        Task<List<Bufferby>> GetHotelsPrice(float Minprice, float Maxprice);

        Task<List<Bufferby>> GetHotelsLocation(string location);

        Task<List<Hotels>> PutHotels(int id, Hotels hotels);

        Task<string> DeleteHotels(int id);
    }
}
