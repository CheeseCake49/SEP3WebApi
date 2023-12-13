using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class CourtLogic : ICourtLogic
{
    private readonly ICourtDAO _courtDao;
    private readonly ITimeSlotLogic _timeSlotLogic;

    public CourtLogic(ICourtDAO courtDao, ITimeSlotLogic timeSlotLogic)
    {
        _courtDao = courtDao;
        _timeSlotLogic = timeSlotLogic;
    }

    public async Task<Court> CreateAsync(int CenterId, CourtCreationDTO courtToCreate)
    {
        Court toCreate = new Court(CenterId, courtToCreate.CourtType, courtToCreate.CourtNumber, courtToCreate.CourtSponsor ?? "");
        Court created = await _courtDao.CreateAsync(toCreate);

        DateTime startTime = DateTime.Today.AddHours(6);
        List<TimeSlot> timeSlots = new();
        List<TimeSlotCreationDTO> timeSlotsToCreate = new();
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 36; i++)
            {
                timeSlotsToCreate.Add(new TimeSlotCreationDTO(created.Id, startTime, 30, false, 100));
                //timeSlots.Add(await _timeSlotLogic.CreateTimeSlotAsync(new TimeSlotCreationDTO(created.Id, startTime, 30, false, 100)));
                startTime = startTime.AddMinutes(30);
            }

            startTime= startTime.AddHours(6);
        }

        timeSlots = await _timeSlotLogic.CreateManyTimeSlotsAsync(timeSlotsToCreate);
        created.TimeSlots = timeSlots;

        return created;
    }

    public async Task DeleteAsync(int centerId, int courtNumber)
    {
        await _courtDao.DeleteAsync(centerId, courtNumber);
    }

    public async Task<Court> UpdateAsync(CourtUpdatingDTO dto)
    {
        Court? existing = await _courtDao.GetByCenterIdAndCourtNumberAsync(dto.CenterId, dto.CourtNumber);
        if (existing != null && existing.Id != dto.Id)
        {
            throw new Exception($"Court with number {dto.CourtNumber} already exist! {dto.Id} {existing.Id}");
        }
        
        Court court = await _courtDao.UpdateAsync(dto);
        return court;
    }

    public async Task<List<Court>> GetCourtsByCenterID(int centerID)
    {
        return await _courtDao.GetCourtsByCenterID(centerID);
    }
    
    public async Task<Court?> GetByIdAsync(int id)
    {
        Court? existing = await _courtDao.GetByIdAsync(id);
        if (existing == null)
        {
            throw new Exception($"Court with ID {id} doesn't exist!");
        }

        return existing;
    }
    
}