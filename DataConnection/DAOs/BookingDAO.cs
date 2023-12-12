using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.proto;
using Shared.Models;

namespace DataConnection.DAOs;

public class BookingDAO : IBookingDAO
{
    private readonly BookingService.BookingServiceClient _bookingService;
    private readonly ITimeSlotDAO _timeSlotDao;
    
    public BookingDAO(ITimeSlotDAO timeSlotDao)
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _bookingService = new BookingService.BookingServiceClient(channel);
        _timeSlotDao = timeSlotDao;
    }


    public async Task<Booking> CreateAsync(Booking booking)
    {
        TimeSlotList list = new TimeSlotList();
        List<TimeSlot> timeSlotList = booking.TimeSlots;

        foreach (TimeSlot timeSlot in timeSlotList)
        {
            list.TimeSlots.Add(_timeSlotDao.ConvertToTimeSlotGrpc(timeSlot));
        }
        
        BookingGrpc createdBooking = await _bookingService.CreateBookingAsync(new CreatingBooking()
        {
            Username = booking.Username,
            TotalPrice = booking.TotalPrice,
            TimeSlotList = list
        });
        
        return ConvertToBooking(createdBooking);
    }

    private Booking ConvertToBooking(BookingGrpc createdBooking)
    {
        var timeSlots = createdBooking.TimeSlotList;
        List<TimeSlot> timeSlotsList = new();
        for (int i = 0; i < timeSlots.TimeSlots.Count; i++)
        {
            timeSlotsList.Add(_timeSlotDao.ConvertToTimeSlot(timeSlots.TimeSlots[i]));
        }
        
        return new Booking
        {
            Id = createdBooking.Id,
            Username = createdBooking.Username,
            TotalPrice = createdBooking.TotalPrice,
            TimeSlots = timeSlotsList
        };
    }
}