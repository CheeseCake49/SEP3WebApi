using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDTO userToCreate);
    Task<List<User>> GetAllUsers();
    Task<List<User>> GetCenterAdminsAsync(int centerId);
}