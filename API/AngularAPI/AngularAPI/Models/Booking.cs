using System;
using System.Collections.Generic;

namespace AngularAPI.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? HotelId { get; set; }

    public int? RoomId { get; set; }

    public int? NoOfAdult { get; set; }

    public int? NoOfChild { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Room? Room { get; set; }
}
