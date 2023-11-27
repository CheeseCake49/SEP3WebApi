using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ICourtLogic
{
    Task<Court> CreateAsync(int CenterId, CourtCreationDTO courtToCreate);
    Task<IEnumerable<Court>> GetCourtsByCenterID(int centerID);
}