using System.Threading.Tasks;
using TestAPIJWT.Models;

namespace TestAPIJWT.Service
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> getTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(RoleModel model);

    }
}
