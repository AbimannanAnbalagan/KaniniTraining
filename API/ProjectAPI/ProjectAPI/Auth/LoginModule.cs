/*using System.ComponentModel.DataAnnotations;
*/
/*namespace JWTCodeFirst.Auth
{
    public class LoginModule
    {
    }
}*/


using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Auth
{
    public class LoginModule
    {
        [Required(ErrorMessage = "Username required")] public string User_name { get; set; }
        [Required(ErrorMessage = "Password required")] public string Password { get; set; }
    }
}