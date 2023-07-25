using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Repository.HotelServices
{
    public class Bufferby
    {

        public int HotelId { get; set; }

        public string? HotelName { get; set; }


        public float price { get; set; }

        public string? Location { get; set; }

        public int Available_Rooms { get; set; }
    }
}
