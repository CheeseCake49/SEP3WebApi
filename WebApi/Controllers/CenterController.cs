using Application.LogicInterfaces;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CenterController : ControllerBase
{
    private readonly ICenterLogic _centerLogic;

    public CenterController(ICenterLogic centerLogic)
    {
        _centerLogic = centerLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Center>> CreateAsync(CenterCreationDTO dto)
    {
        try
        {
            Center center = await _centerLogic.CreateAsync(dto);
            return Created($"/Center/{center.Id}", center);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Name is already in use");
        }
    }
    
    [HttpDelete("/center/{id:int}")]
    public async Task<ActionResult> DeleteAsync([FromRoute] int id)
    {
        try
        {
            await _centerLogic.DeleteAsync(id);
            return Ok();
        }
        catch (RpcException e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Status.Detail);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Center>>> GetCentersAsync()
    {
        try
        {
            var centers = await _centerLogic.GetAllCentersAsync();
            return Ok(centers);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpPost("/center/{id:int}/admins")]
    public async Task<ActionResult<string>> AddCenterAdminAsync([FromRoute] int id, [FromBody] CenterAdminDTO dto)
    {
        try
        {
            CenterAdminDTO created = new(id, await _centerLogic.AddCenterAdminAsync(id, dto.username));
            return Ok(created);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

}