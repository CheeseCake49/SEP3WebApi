using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class BookingLogic : IBookingLogic
{
    private readonly IBookingDAO _bookingDao;
    private readonly IUserLogic _userLogic;
    private readonly IBookingAddOnLogic _bookingAddOnLogic;

    public BookingLogic(IBookingDAO bookingDao, IUserLogic userLogic, IBookingAddOnLogic bookingAddOnLogic)
    {
        _bookingDao = bookingDao;
        _userLogic = userLogic;
        _bookingAddOnLogic = bookingAddOnLogic;
    }

    public async Task<Booking> CreateBookingAsync(BookingCreationDTO bookingToCreate)
    {
        Booking toCreate = new Booking(bookingToCreate.Username, bookingToCreate.TotalPrice, bookingToCreate.TimeSlots);
        Booking created = await _bookingDao.CreateAsync(toCreate);

        if (bookingToCreate.BookingAddOns != null)
        {
            List<BookingAddOn> bookingAddOns = new List<BookingAddOn>();
            foreach (BookingAddOnCreationDTO bookingAddOnToCreate in bookingToCreate.BookingAddOns)
            {
                bookingAddOns.Add(await _bookingAddOnLogic.CreateBookingAddOnAsync(bookingAddOnToCreate, created.Id));
            }

            created.BookingAddOns = bookingAddOns;
        }
        return created;
    }
}