using System;
using System.Collections.Generic;

namespace ProjectAPI.Models;

public partial class Productdetail
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public string Producttype { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Costperquantity { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
