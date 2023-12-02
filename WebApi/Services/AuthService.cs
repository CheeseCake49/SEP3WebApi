using Application.DAOInterfaces;
using Shared.Models;

namespace Sep3WebApi.Services;

public class AuthService : IAuthService
{
    
    private IEnumerable<User> users;
    private readonly IUserDAO _userDao;

    public AuthService(IUserDAO userDao)
    {
        _userDao = userDao;
    }
    
    public async Task<User> ValidateUser(string username, string password)
    {
        users = await _userDao.GetAllUsersAsync();
        User? existingUser = users.FirstOrDefault(u => 
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        
        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }
        
        return existingUser;
    }

}