using eShopSolution.ViewModels.Common;
using ShopAssignment.ViewModels.System.Users;
using ShopAssignment.ViewModels.System.Users.Request;

namespace ShopAssignment.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<UserViewModel> GetByUserName(string userName);
        string GenerateRefreshToken();

        Task<bool> Register(RegisterRequest request);
    }
}