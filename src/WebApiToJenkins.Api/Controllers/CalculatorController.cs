using Microsoft.AspNetCore.Mvc;
using WebApiToJenkins.Api.Models;

namespace WebApiToJenkins.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("multiplybytwo/{id:int}")]
    public IActionResult GetNumberMultipliedByTwo(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }

        var result = new ObjectCalculatedResponse
        {
            ResultingValue = id * 2
        };

        return Ok(result);
    }
}
