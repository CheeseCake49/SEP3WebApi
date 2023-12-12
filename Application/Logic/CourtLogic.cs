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
        Court toCreate = new Court(CenterId, courtToCreate.CourtType, courtToCreate.CourtNumber, courtToCreate.CourtSponsor ?? "");
        Court created = await courtDAO.CreateAsync(toCreate);

        DateTime startTime = DateTime.Today.AddHours(6);
        List<TimeSlot> timeSlots = new List<TimeSlot>();
        for (int j = 0; j < 30; j++)
        {
            for (int i = 0; i < 36; i++)
            {
                timeSlots.Add(new TimeSlot(created.Id, startTime, 30, false, 100));
                startTime = startTime.AddMinutes(30);
            }

            startTime= startTime.AddHours(6);
        }

        return created;
    }

    public async Task DeleteAsync(int centerId, int courtNumber)
    {
        await courtDAO.DeleteAsync(centerId, courtNumber);
    }

    public async Task<Court> UpdateAsync(CourtUpdatingDTO dto)
    {
        Court? existing = await courtDAO.GetByCenterIdAndCourtNumberAsync(dto.centerId, dto.courtNumber);
        if (existing != null && existing.Id != dto.id)
        {
            throw new Exception($"Court with number {dto.courtNumber} already exist! {dto.id} {existing.Id}");
        }
        
        Court court = await courtDAO.UpdateAsync(dto);
        return court;
    }

    public async Task<List<Court>> GetCourtsByCenterID(int centerID)
    {
        return await courtDAO.GetCourtsByCenterID(centerID);
    }
    
    public async Task<Court?> GetByIdAsync(int id)
    {
        Court? existing = await courtDAO.GetByIdAsync(id);
        if (existing == null)
        {
            throw new Exception($"Court with ID {id} doesn't exist!");
        }

        return existing;
    }
    
}