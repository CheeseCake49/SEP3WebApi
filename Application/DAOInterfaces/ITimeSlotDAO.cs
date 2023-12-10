using Shared.Models;

namespace Application.DAOInterfaces;

public interface ITimeSlotDAO
{
    Task<TimeSlot> CreateAsync(TimeSlot timeSlot);
    Task<List<TimeSlot>> GetTimeSlotsByCourt(int courtId);
}