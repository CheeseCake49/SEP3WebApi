using Shared.Models;

namespace Application.DAOInterfaces;

public interface ICenterDAO
{
    Task<Center> CreateAsync(Center center);
    Task<List<Center>> GetAllCentersAsync();
}