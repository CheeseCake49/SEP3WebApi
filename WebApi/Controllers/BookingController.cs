using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    private readonly IBookingLogic _bookingLogic;
    
    public BookingController(IBookingLogic bookingLogic)
    {
        _bookingLogic = bookingLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult<Booking>> CreateAsync(BookingCreationDTO dto)
    {
        try
        {
            Booking booking = await _bookingLogic.CreateBookingAsync(dto);
            return Created($"/Booking/{booking.Id}", booking);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
}