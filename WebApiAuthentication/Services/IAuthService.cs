using WebApiAuthentication.Models;

namespace WebApiAuthentication.Services
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser loginUser);
        Task<bool> LoginUser(LoginUser loginUser);
        Task<bool> RegisterUser(LoginUser loginUser);
    }
}