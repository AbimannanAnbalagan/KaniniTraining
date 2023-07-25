using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter the username")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter the email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter the password")]
        public string? Password { get; set; } 
    }
}
