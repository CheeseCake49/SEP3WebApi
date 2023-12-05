using Shared.DTOs;
using Shared.Models;

namespace Application.DAOInterfaces;

public interface ICenterDAO
{
    Task<Center> CreateAsync(Center center);
    Task DeleteAsync(int id);
    Task<List<Center>> GetAllCentersAsync();
    Task<Task> UpdateAsync(CenterUpdatingDTO dto);
    Task<Center?> GetByIdAsync(int id);
}