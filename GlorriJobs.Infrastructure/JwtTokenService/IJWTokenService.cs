using System.Security.Claims;

namespace GlorriJobs.Infrastructure.JwtTokenService
{
    public interface IJWTokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
    }
}
