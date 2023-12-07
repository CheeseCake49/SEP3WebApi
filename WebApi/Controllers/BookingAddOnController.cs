using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingAddOnController : ControllerBase
{
    private readonly IBookingAddOnLogic _bookingAddOnLogic;
    
    public BookingAddOnController(IBookingAddOnLogic bookingAddOnLogic)
    {
        _bookingAddOnLogic = bookingAddOnLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult<BookingAddOn>> CreateAsync(BookingAddOnCreationDTO dto)
    {
        try
        {
            BookingAddOn bookingAddOn = await _bookingAddOnLogic.CreateBookingAddOnAsync(dto);
            return Created($"/BookingAddOn/{bookingAddOn.Id}", bookingAddOn);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}