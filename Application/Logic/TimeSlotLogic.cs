using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class TimeSlotLogic : ITimeSlotLogic
{
    private readonly ITimeSlotDAO timeSlotDAO;
    private readonly ICourtDAO courtDAO;

    public TimeSlotLogic(ITimeSlotDAO timeSlotDao, ICourtDAO courtDao)
    {
        this.timeSlotDAO = timeSlotDao;
        this.courtDAO = courtDao;
    }

    public async Task<TimeSlot> CreateTimeSlotAsync(TimeSlotCreationDTO timeSlotToCreate)
    {
        TimeSlot toCreate = new TimeSlot(timeSlotToCreate.courtId, timeSlotToCreate.startTime, timeSlotToCreate.duration);
        
        return await timeSlotDAO.CreateAsync(toCreate);
    }
}