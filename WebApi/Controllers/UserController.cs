using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace Sep3WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserLogic _userLogic;

    public UserController(IUserLogic userLogic)
    {
        _userLogic = userLogic;
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateAsync(UserCreationDTO dto)
    {
        try
        {
            User user = await _userLogic.CreateAsync(dto);
            return Created($"/User/{user.Username}", user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAllUsersAsync()
    {
        return await _userLogic.GetAllUsers();
    }

    [HttpGet("/user/admins/{centerId:int}")]
    public async Task<ActionResult<List<User>>> GetCenterAdminsAsync([FromRoute] int centerId)
    {
        return await _userLogic.GetCenterAdminsAsync(centerId);
    }
    
}