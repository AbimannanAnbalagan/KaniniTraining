using System;
using System.Collections.Generic;

namespace AngularAPI.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int? HotelId { get; set; }

    public int? RoomNo { get; set; }

    public string? AvailabilityStatus { get; set; }

    public string? Type { get; set; }

    public decimal? Cost { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Hotel? Hotel { get; set; }
}
