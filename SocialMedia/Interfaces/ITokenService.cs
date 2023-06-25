using SocialMedia.Models;

namespace SocialMedia.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
