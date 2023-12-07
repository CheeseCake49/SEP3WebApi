using Application.DAOInterfaces;
using Grpc.Net.Client;
using sep3client.booking;
using Shared.Models;

namespace DataConnection.DAOs;

public class BookingDAO : IBookingDAO
{
    private readonly BookingService.BookingServiceClient _bookingService;
    
    public BookingDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _bookingService = new BookingService.BookingServiceClient(channel);
    }


    public async Task<Booking> CreateAsync(Booking booking)
    {
        BookingGrpc createdBooking = await _bookingService.CreateBookingAsync(new CreatingBooking()
        {
            Username = booking.Username,
            TotalPrice = booking.TotalPrice
        });
        
        return ConvertToBooking(createdBooking);
    }

    private Booking ConvertToBooking(BookingGrpc createdBooking)
    {
        return new Booking
        {
            Id = createdBooking.Id,
            Username = createdBooking.Username,
            TotalPrice = createdBooking.TotalPrice
        };
    }
}