using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface IBookingAddOnLogic
{
    Task<BookingAddOn> CreateBookingAddOnAsync(BookingAddOnCreationDTO bookingAddOnToCreate);
}