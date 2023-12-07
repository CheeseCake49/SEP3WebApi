using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Grpc.Net.Client;
using sep3client.bookingaddon;
using Shared.DTOs;
using Shared.Models;

namespace DataConnection.DAOs;

public class BookingAddOnDAO : IBookingAddOnDAO
{
    private readonly BookingAddOnService.BookingAddOnServiceClient _bookingAddOnService;
    
    public BookingAddOnDAO()
    {
        var channel = GrpcChannel.ForAddress("http://localhost:6565");
        _bookingAddOnService = new BookingAddOnService.BookingAddOnServiceClient(channel);
    }

    public async  Task<BookingAddOn> CreateAsync(BookingAddOn bookingAddOn)
    {
        BookingAddOnGrpc createdBookingAddOn = await _bookingAddOnService.CreateBookingAddOnAsync(new CreatingBookingAddOn()
        {
            BookingId = bookingAddOn.BookingId,
            Name = bookingAddOn.Name,
            Price = bookingAddOn.Price,
            Quantity = bookingAddOn.Quantity
        });
        
        return ConvertToBookingAddOn(createdBookingAddOn);
    }

    private BookingAddOn ConvertToBookingAddOn(BookingAddOnGrpc createdBookingAddOn)
    {
        return new BookingAddOn
        {
            Id = createdBookingAddOn.Id,
            BookingId = createdBookingAddOn.BookingId,
            Name = createdBookingAddOn.Name,
            Price = createdBookingAddOn.Price,
            Quantity = createdBookingAddOn.Quantity
        };
    }
}