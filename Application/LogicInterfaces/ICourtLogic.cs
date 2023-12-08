using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICourtLogic
{
    Task<Court> CreateAsync(int CenterId, CourtCreationDTO courtToCreate);
    Task DeleteAsync(int centerId, int courtNumber);
    Task<Court> UpdateAsync(CourtUpdatingDTO dto);
    Task<List<Court>> GetCourtsByCenterID(int centerID);
    Task<Court?> GetByIdAsync(int id);
}