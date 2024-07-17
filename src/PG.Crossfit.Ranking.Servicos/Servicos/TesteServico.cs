using PG.Crossfit.Ranking.Dominio.Interfaces;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Repository.Interfaces;

namespace PG.Crossfit.Ranking.Servicos.Servicos;

internal class TesteServico : ITesteServico
{
    private readonly ITesteRepository repositorio;

    public TesteServico(ITesteRepository repositorio)
    {
        this.repositorio = repositorio;
    }

    public async Task<string> ObterTesteAsync(int codigo, CancellationToken cancellationToken = default)
    {
        var teste = await repositorio.GetTesteByIdAsync(codigo);

        return teste.Nome;
    }
}
