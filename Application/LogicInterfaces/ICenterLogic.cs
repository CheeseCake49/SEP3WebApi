using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICenterLogic
{
    Task<Center> CreateAsync(CenterCreationDTO centerToCreate);
    Task DeleteAsync(int id);
    Task<IEnumerable<Center>> GetAllCentersAsync();
    Task<Center> UpdateAsync(CenterUpdatingDTO dto);
    Task<Center?> GetByIdAsync(int id);
    Task<string> AddCenterAdminAsync(int centerId, string username);
}