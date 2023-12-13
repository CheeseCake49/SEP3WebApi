using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class TimeSlotLogic : ITimeSlotLogic
{
    private readonly ITimeSlotDAO _timeSlotDao;

    public TimeSlotLogic(ITimeSlotDAO timeSlotDao)
    {
        _timeSlotDao = timeSlotDao;
    }

    public async Task<TimeSlot> CreateTimeSlotAsync(TimeSlotCreationDTO timeSlotToCreate)
    {
        TimeSlot toCreate = new TimeSlot(timeSlotToCreate.CourtId, timeSlotToCreate.StartTime, timeSlotToCreate.Duration, timeSlotToCreate.IsBooked, timeSlotToCreate.Price);
        
        return await _timeSlotDao.CreateAsync(toCreate);
    }

    public async Task<List<TimeSlot>> CreateManyTimeSlotsAsync(List<TimeSlotCreationDTO> timeSlotsToCreate)
    {
        List<TimeSlot> toCreate = new List<TimeSlot>(timeSlotsToCreate.Select(t =>
            new TimeSlot(t.CourtId, t.StartTime, t.Duration, t.IsBooked, t.Price)));

        return await _timeSlotDao.CreateManyAsync(toCreate);
    }

    public async Task<List<TimeSlot>> GetTimeSlotsByCourtAsync(int courtId)
    {
        return await _timeSlotDao.GetTimeSlotsByCourt(courtId);
    }
}