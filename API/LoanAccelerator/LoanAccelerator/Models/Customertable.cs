using System;
using System.Collections.Generic;

namespace LoanAccelerator.Models;

public partial class Customertable
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<LoanTable> LoanTables { get; set; } = new List<LoanTable>();
}
