using sep3client.proto;
using Shared.Models;

namespace Application.DAOInterfaces;

public interface ITimeSlotDAO
{
    Task<TimeSlot> CreateAsync(TimeSlot timeSlot);
    Task<List<TimeSlot>> CreateManyAsync(List<TimeSlot> timeSlots);
    Task<List<TimeSlot>> GetTimeSlotsByCourt(int courtId);
    TimeSlot ConvertToTimeSlot(TimeSlotGrpc timeSlot);
    TimeSlotGrpc ConvertToTimeSlotGrpc(TimeSlot timeSlot);
}