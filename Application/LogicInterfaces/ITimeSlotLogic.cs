using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ITimeSlotLogic
{
    Task<TimeSlot> CreateTimeSlotAsync(TimeSlotCreationDTO timeSlotToCreate);
    Task<List<TimeSlot>> CreateManyTimeSlotsAsync(List<TimeSlotCreationDTO> timeSlotsToCreate);
    Task<List<TimeSlot>> GetTimeSlotsByCourtAsync(int courtId);
}