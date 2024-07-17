using MediatR;
using PG.Crossfit.Ranking.Dominio.Interfaces;
using PG.Crossfit.Ranking.Mediador.Requisicoes.Consultas;

namespace PG.Crossfit.Ranking.Mediador.Handlers.Consultas;

internal class TesteHandler : IRequestHandler<TesteConsulta, string>
{
    private readonly ITesteServico servico;

    public TesteHandler(ITesteServico servico)
    {
        this.servico = servico;
    }

    public Task<string> Handle(TesteConsulta request, CancellationToken cancellationToken)
    {
        return servico.ObterTesteAsync(request.Codigo, cancellationToken);
    }
}