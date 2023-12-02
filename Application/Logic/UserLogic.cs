using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDAO _userDao;

    public UserLogic(IUserDAO userDao)
    {
        _userDao = userDao;
    }

    public async Task<User> CreateAsync(UserCreationDTO userToCreate)
    {
        ValidateData(userToCreate);
        User toCreate = new User(userToCreate.Username, userToCreate.Password, userToCreate.Email, userToCreate.Name, userToCreate.Role);
        
        return await _userDao.CreateAsync(toCreate);
    }
    
    public async Task<IEnumerable<User>> getAllUsers()
    {
        List<User> users = await _userDao.GetAllUsersAsync();

        return users;
    }
    
    private static void ValidateData(UserCreationDTO userToCreate)
    {
        string username = userToCreate.Username;

        if (username.Length < 3)
            throw new Exception("Username must be at least 3 characters");

        if (username.Length > 15)
            throw new Exception("Username must be less than 16 characters");
    }
    
}