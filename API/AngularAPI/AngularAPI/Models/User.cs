using System;
using System.Collections.Generic;

namespace AngularAPI.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Roles { get; set; }

    public long? MobileNumber { get; set; }

    public virtual ICollection<UserFeedback> UserFeedbacks { get; set; } = new List<UserFeedback>();
}
