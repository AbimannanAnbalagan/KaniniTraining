﻿using Microsoft.Build.Framework;

namespace AngularAPI.Authentication
{
    public class RegistrationModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}

