using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using sep3client.court;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CourtController : ControllerBase
{

    private readonly ICourtLogic _courtLogic;

    public CourtController(ICourtLogic courtLogic)
    {
        _courtLogic = courtLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Court>> CreateAsync(int centerId, CourtCreationDTO dto)
    {
        try
        {
            Court court = await _courtLogic.CreateAsync(centerId, dto);
            return Created($"/Court/{court.Id}", court);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet("/court/{CenterId:int}")]
    public async Task<ActionResult<IEnumerable<Court>>> GetCourtsAsync([FromRoute] int CenterId)
    {
        try
        {
            var courts = await _courtLogic.GetCourtsByCenterID(CenterId);
            return Ok(courts);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

}