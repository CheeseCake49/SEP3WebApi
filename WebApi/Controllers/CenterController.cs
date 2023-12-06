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
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
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

    [HttpPatch]
    public async Task<ActionResult<Center>> UpdateAsync(CenterUpdatingDTO dto)
    {
        try
        {
            Center center = await _centerLogic.UpdateAsync(dto);
            return Ok(center);
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

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Center?>> GetByIdAsync([FromRoute] int id)
    {
        try
        {
            return await _centerLogic.GetByIdAsync(id);
        } catch (RpcException e)
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

}