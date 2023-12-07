using Shared.Models;

namespace Application.DAOInterfaces;

public interface IBookingDAO
{
    Task<Booking> CreateAsync(Booking booking);
}