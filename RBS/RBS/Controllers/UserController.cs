using Microsoft.AspNetCore.Mvc;

namespace RBS.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    [HttpGet("id")]
    public IActionResult Index()
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> CreateAsync()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateAsync()
    {
        return Ok();
    }
}