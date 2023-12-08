using Shared.Models;

namespace Application.DAOInterfaces;

public interface IUserDAO
{
    Task<User> CreateAsync(User user);
    Task<List<User>> GetAllUsersAsync();
    Task<List<User>> GetCenterAdminsAsync(int centerId);

}