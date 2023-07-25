using AngularAPI.Authentication;
using System.Security.Claims;

namespace AngularAPI.Services.AuthRepo
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
