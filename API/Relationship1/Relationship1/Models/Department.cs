using System;
using System.Collections.Generic;

namespace Relationship1.Models;

public partial class Department
{
    public int DeptNo { get; set; }

    public string? DeptName { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
