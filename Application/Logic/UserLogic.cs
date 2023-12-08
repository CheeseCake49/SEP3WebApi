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
        User toCreate = new User(userToCreate.Username, userToCreate.Password, userToCreate.Email, userToCreate.Name, userToCreate.Role);
        
        return await _userDao.CreateAsync(toCreate);
    }
    
    public async Task<List<User>> GetAllUsers()
    {
        List<User> users = await _userDao.GetAllUsersAsync();

        return users;
    }

    public async Task<List<User>> GetCenterAdminsAsync(int centerId)
    {
        return await _userDao.GetCenterAdminsAsync(centerId);
    }
}