using Microsoft.AspNetCore.Mvc;
using WebApiToJenkins.Api.Models;

namespace WebApiToJenkins.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("multiplybytwo/{num:int}")]
    public IActionResult GetNumberMultipliedByTwo(int num)
    {
        if (num == 0) return BadRequest();

        var result = new ObjectCalculatedResponse { Result = num * 2 };

        return Ok(result);
    }
}
