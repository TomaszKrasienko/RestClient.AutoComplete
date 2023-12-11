using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs;

namespace TestApi.Controllers;

[ApiController]
[Route("tests")]
public class TestController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostTest(TestPost testPost)
    {
        return Ok();
    }
}