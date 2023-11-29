using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class CourtLogic : ICourtLogic
{
    private readonly ICourtDAO courtDAO;

    public CourtLogic(ICourtDAO courtDao)
    {
        this.courtDAO = courtDao;
    }

    public async Task<Court> CreateAsync(int CenterId, CourtCreationDTO courtToCreate)
    {
        Court toCreate = new Court(CenterId, courtToCreate.CourtType, courtToCreate.CourtNumber, courtToCreate.CourtSponsor);

        return await courtDAO.CreateAsync(toCreate);
    }

    public async Task DeleteAsync(int centerId, int courtNumber)
    {
        await courtDAO.DeleteAsync(centerId, courtNumber);
    }

    

    public async Task<List<Court>> GetCourtsByCenterID(int centerID)
    {
        return await courtDAO.GetCourtsByCenterID(centerID);
    }
    
}