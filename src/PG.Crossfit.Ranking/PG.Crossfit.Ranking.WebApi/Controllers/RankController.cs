using Microsoft.AspNetCore.Mvc;

namespace PG.Crossfit.Ranking.WebApi.Controllers;

[ApiController]
[Route("ranking/v1/[controller]/[action]")]
public class RankController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Teste");
    }
}
