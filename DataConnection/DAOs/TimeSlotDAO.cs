using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.timeslot;
using Shared.Models;

namespace DataConnection.DAOs;

public class TimeSlotDAO : ITimeSlotDAO
{
    private readonly TimeSlotService.TimeSlotServiceClient _timeSlotService;
    
    public TimeSlotDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _timeSlotService = new TimeSlotService.TimeSlotServiceClient(channel);
    }


    public async Task<TimeSlot> CreateAsync(TimeSlot timeSlot)
    {
        TimeSlotGrpc createdTimeSlot = await _timeSlotService.CreateTimeSlotAsync(new CreatingTimeSlot()
        {
            CourtId = timeSlot.courtId,
            Year = timeSlot.startTime.Year,
            Month = timeSlot.startTime.Month,
            Day = timeSlot.startTime.Day,
            StartHour = timeSlot.startTime.Hour,
            StartMinute = timeSlot.startTime.Minute,
            Duration = timeSlot.duration,
            IsBooked = timeSlot.isBooked
        });
        return ConvertToTimeSlot(createdTimeSlot);
    }

    public async Task<List<TimeSlot>> GetTimeSlotsByCourt(int courtId)
    {
        var timeSlots = await _timeSlotService.GetTimeSlotsFromCourtIdAsync(new courtId()
        {
            CourtId = courtId
        });
        List<TimeSlot> timeSlotList = new();
        for (int i = 0; i < timeSlots.TimeSlots.Count; i++)
        {
            timeSlotList.Add(ConvertToTimeSlot(timeSlots.TimeSlots[i]));
        }

        return timeSlotList;
    }

    private TimeSlot ConvertToTimeSlot(TimeSlotGrpc timeSlot)
    {
        return new TimeSlot()
        {
            Id = timeSlot.Id,
            courtId = timeSlot.CourtId,
            startTime = convertToDateTime(timeSlot.Year, timeSlot.Month, timeSlot.Day, timeSlot.StartHour, timeSlot.StartMinute),
            duration = timeSlot.Duration,
            isBooked = timeSlot.IsBooked
        };
    }
    
    public DateTime convertToDateTime(int year, int month, int day, int hour, int minute)
    {
        return new DateTime(year, month, day, hour, minute, 0);
    }
}