using Hotel_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_System.Repository.UserServices
{
    public interface Iuserservices 
    {
        Task<List<User>> GetUsers();
    }
}
