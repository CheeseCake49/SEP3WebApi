using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.proto;
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
            CourtId = timeSlot.CourtId,
            Year = timeSlot.StartTime.Year,
            Month = timeSlot.StartTime.Month,
            Day = timeSlot.StartTime.Day,
            StartHour = timeSlot.StartTime.Hour,
            StartMinute = timeSlot.StartTime.Minute,
            Duration = timeSlot.Duration,
            IsBooked = timeSlot.IsBooked,
            Price = timeSlot.Price
        });
        return ConvertToTimeSlot(createdTimeSlot);
    }

    public async Task<List<TimeSlot>> GetTimeSlotsByCourt(int courtId)
    {
        var timeSlots = await _timeSlotService.GetTimeSlotsFromCourtIdAsync(new CourtId()
        {
            Id = courtId
        });
        List<TimeSlot> timeSlotList = new();
        for (int i = 0; i < timeSlots.TimeSlots.Count; i++)
        {
            timeSlotList.Add(ConvertToTimeSlot(timeSlots.TimeSlots[i]));
        }

        return timeSlotList;
    }

    public TimeSlot ConvertToTimeSlot(TimeSlotGrpc timeSlot)
    {
        return new TimeSlot()
        {
            Id = timeSlot.Id,
            CourtId = timeSlot.CourtId,
            StartTime = convertToDateTime(timeSlot.Year, timeSlot.Month, timeSlot.Day, timeSlot.StartHour, timeSlot.StartMinute),
            Duration = timeSlot.Duration,
            IsBooked = timeSlot.IsBooked,
            Price = timeSlot.Price
        };
    }

    public TimeSlotGrpc ConvertToTimeSlotGrpc(TimeSlot timeSlot)
    {
        return new TimeSlotGrpc
        {
            Id = timeSlot.Id,
            CourtId = timeSlot.CourtId,
            Year = timeSlot.StartTime.Year,
            Month = timeSlot.StartTime.Month,
            Day = timeSlot.StartTime.Day,
            StartHour = timeSlot.StartTime.Hour,
            StartMinute = timeSlot.StartTime.Minute,
            Duration = timeSlot.Duration,
            IsBooked = timeSlot.IsBooked,
            Price = timeSlot.Price
        };
    }
    
    public DateTime convertToDateTime(int year, int month, int day, int hour, int minute)
    {
        return new DateTime(year, month, day, hour, minute, 0);
    }
}