using Microsoft.AspNetCore.Identity;

namespace AngularAPI.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
