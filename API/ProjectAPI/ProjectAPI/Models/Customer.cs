using System;
using System.Collections.Generic;

namespace ProjectAPI.Models;

public partial class Customer
{
    public int Cusid { get; set; }

    public string Cusname { get; set; } = null!;

    public long Cusph { get; set; }

    public string? Cusaddress { get; set; }

    public string Cuspassword { get; set; } = null!;

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
