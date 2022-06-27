using ShopAssignment.ViewModels.System.Users.Request;

namespace ShopAssignment.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
    }
}