using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeSlotController : ControllerBase
{
    private readonly ITimeSlotLogic _timeSlotLogic;
    
    public TimeSlotController(ITimeSlotLogic timeSlotLogic)
    {
        _timeSlotLogic = timeSlotLogic;
    }
    
    [HttpPost("/timeslot/{courtId:int}/{bookingTime:DateTime}")]
    public async Task<ActionResult<TimeSlot>> CreateTimeSlotAsync([FromRoute] int courtId, [FromRoute] DateTime bookingTime, [FromBody] TimeSlotCreationDTO dto)
    {
        try
        {
            TimeSlot timeSlot = await _timeSlotLogic.CreateTimeSlotAsync(dto);
            return Created($"/TimeSlot/{timeSlot.Id}", timeSlot);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet("/timeslot/{courtId:int}")]
    public async Task<ActionResult<TimeSlot>> GetTimeSlotByCourtIdAsync([FromBody] int courtId)
    {
        try
        {
            TimeSlot timeSlot = await _timeSlotLogic.GetTimeSlotByCourtAsync(courtId);
            return Ok(timeSlot);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}