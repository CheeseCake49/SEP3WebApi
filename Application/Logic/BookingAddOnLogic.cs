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


    public async Task<BookingAddOn> CreateBookingAddOnAsync(BookingAddOnCreationDTO bookingAddOnToCreate, int bookingId)
    {
        BookingAddOn toCreate = new BookingAddOn(bookingId, bookingAddOnToCreate.Name, 
            bookingAddOnToCreate.Price, bookingAddOnToCreate.Quantity);
        return await _bookingAddOnDao.CreateAsync(toCreate);
    }
}