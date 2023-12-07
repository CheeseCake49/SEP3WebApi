using Shared.DTOs;
using Shared.Models;

namespace Application.DAOInterfaces;

public interface ICourtDAO
{
    Task<Court> CreateAsync(Court court);
    Task DeleteAsync(int centerId, int courtNumber);
    Task<List<Court>> GetCourtsByCenterID(int centerID);
    Task<Court> UpdateAsync(CourtUpdatingDTO dto);
    Task<Court?> GetByCenterIdAndCourtNumberAsync(int centerId, int courtNumber);
}