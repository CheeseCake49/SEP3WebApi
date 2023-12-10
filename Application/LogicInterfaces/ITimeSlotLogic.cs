using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface ITimeSlotLogic
{
    Task<TimeSlot> CreateTimeSlotAsync(TimeSlotCreationDTO timeSlotToCreate);
    Task<TimeSlot> GetTimeSlotByCourtAsync(int courtId);
}