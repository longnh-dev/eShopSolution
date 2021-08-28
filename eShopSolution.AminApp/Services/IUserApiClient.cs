using eShopSolution.ViewModels.System.Users;
using System.Threading.Tasks;

namespace eShopSolution.AminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}