using MediatR;

namespace PG.Crossfit.Ranking.Mediador.Requisicoes.Consultas;

public record TesteConsulta(int Codigo) : IRequest<string>;
