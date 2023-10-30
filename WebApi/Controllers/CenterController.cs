using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CenterController : ControllerBase
{
    private readonly ICenterLogic centerLogic;

    public CenterController(ICenterLogic centerLogic)
    {
        this.centerLogic = centerLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Center>> CreateAsync(CenterCreationDTO dto)
    {
        try
        {
            Center center = await centerLogic.CreateAsync(dto);
            return Created($"/center/{center.Id}", center);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

}