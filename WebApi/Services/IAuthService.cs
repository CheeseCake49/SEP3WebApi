using Shared.Models;

namespace Sep3WebApi.Services;

public interface IAuthService
{
    Task<User> ValidateUser(string username, string password);
}