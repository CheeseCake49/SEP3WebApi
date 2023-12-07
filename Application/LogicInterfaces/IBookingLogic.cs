using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface IBookingLogic
{
    Task<Booking> CreateBookingAsync(BookingCreationDTO bookingToCreate);
}