using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class BookingAddOnLogic : IBookingAddOnLogic
{
    private readonly IBookingAddOnDAO _bookingAddOnDao;
    
    public BookingAddOnLogic(IBookingAddOnDAO bookingAddOnDao)
    {
        _bookingAddOnDao = bookingAddOnDao;
    }


    public async Task<BookingAddOn> CreateBookingAddOnAsync(BookingAddOnCreationDTO bookingAddOnToCreate)
    {
        BookingAddOn toCreate = new BookingAddOn(bookingAddOnToCreate.BookingId, bookingAddOnToCreate.Name, 
            bookingAddOnToCreate.Price, bookingAddOnToCreate.Quantity);
        return await _bookingAddOnDao.CreateAsync(toCreate);
    }
}