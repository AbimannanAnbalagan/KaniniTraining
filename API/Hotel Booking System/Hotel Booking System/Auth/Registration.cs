﻿using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Auth
{
    public class Registrationmodule
    {
        [Required(ErrorMessage = "Uername required")] public string? User_name { get; set; }
        [Required(ErrorMessage = "Email required")] public string? Email { get; set; }
        [Required(ErrorMessage = "Password required")] public string? Password { get; set; }

    }
}