using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICenterLogic
{
    Task<Center> CreateAsync(CenterCreationDTO centerToCreate);
    Task DeleteAsync(int id);
    Task<IEnumerable<Center>> GetAllCentersAsync();
    Task<string> AddCenterAdminAsync(int centerId, string username);
}