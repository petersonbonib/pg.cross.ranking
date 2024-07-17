using Microsoft.AspNetCore.Mvc;
using PG.Crossfit.Ranking.Dominio.Interfaces;

namespace PG.Crossfit.Ranking.WebApi.Controllers;

[ApiController]
[Route("ranking/v1/[controller]/[action]")]
public class RankController : ControllerBase
{
    private readonly ITesteServico servico;

    public RankController(ITesteServico servico)
    {
        this.servico = servico;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int codigo)
    {
        var nome = await servico.ObterTesteAsync(codigo);
        return Ok(nome);
    }
}
