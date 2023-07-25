using System;
using System.Collections.Generic;

namespace AngularAPI.Models;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? HotelName { get; set; }

    public int? TotalRooms { get; set; }

    public string? Location { get; set; }

    public long? ContactNumber { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
