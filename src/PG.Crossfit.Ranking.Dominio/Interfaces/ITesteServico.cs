namespace PG.Crossfit.Ranking.Dominio.Interfaces;

public interface ITesteServico
{
    Task<string> ObterTesteAsync(int codigo, CancellationToken cancellationToken = default);
}
