using Shared.Models;

namespace Application.DAOInterfaces;

public interface IBookingAddOnDAO
{
    Task<BookingAddOn> CreateAsync(BookingAddOn bookingAddOn);
}