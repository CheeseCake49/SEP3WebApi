using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICenterLogic
{
    Task<Center> CreateAsync(CenterCreationDTO centerToCreate);
    Task DeleteAsync(int id);
    Task<IEnumerable<Center>> GetAllCentersAsync();
    Task UpdateAsync(CenterUpdatingDTO dto);
    Task<Center?> GetByIdAsync(int id);
}