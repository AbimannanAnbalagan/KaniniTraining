using System;
using System.Collections.Generic;

namespace AngularAPI.Models;

public partial class UserFeedback
{
    public int FeedbackId { get; set; }

    public int? UserId { get; set; }

    public string? Feedback { get; set; }

    public virtual User? User { get; set; }
}
