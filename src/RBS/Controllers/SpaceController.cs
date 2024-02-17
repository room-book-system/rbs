using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RBS.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SpaceController : ControllerBase
{
    private static readonly string[] test = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet("{id}")]
    [Authorize]
    public async Task<IActionResult> GetSpaceById(int id)
    {
        return Ok(test[id]);
    }

    [HttpGet("list")]
    public async Task<IActionResult> GetAllSpaces()
    {
        return Ok(test);
    }
}