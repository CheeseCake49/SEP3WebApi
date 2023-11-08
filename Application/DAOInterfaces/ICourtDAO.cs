using Shared.Models;

namespace Application.DAOInterfaces;

public interface ICourtDAO
{
    Task<Court> CreateAsync(Court court);
}