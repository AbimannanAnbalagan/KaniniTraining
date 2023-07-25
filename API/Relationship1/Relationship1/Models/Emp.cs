using System;
using System.Collections.Generic;

namespace Relationship1.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? EmpName { get; set; }

    public int? DepNo { get; set; }

    public virtual Department? DepNoNavigation { get; set; }
}
