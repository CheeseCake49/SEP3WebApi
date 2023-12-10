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
    public async Task<ActionResult<TimeSlot>> CreateTimeSlotAsync([FromBody] TimeSlotCreationDTO dto)
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
    public async Task<ActionResult<TimeSlot>> GetTimeSlotsByCourtIdAsync([FromQuery] int courtId)
    {
        try
        {
            List<TimeSlot> timeSlot = await _timeSlotLogic.GetTimeSlotsByCourtAsync(courtId);
            return Ok(timeSlot);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}