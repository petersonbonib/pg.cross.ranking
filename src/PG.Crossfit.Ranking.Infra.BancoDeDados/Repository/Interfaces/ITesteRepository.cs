using PG.Crossfit.Ranking.Dominio.Entidades;

namespace PG.Crossfit.Ranking.Infra.BancoDeDados.Repository.Interfaces;

public interface ITesteRepository
{
    Task<Teste> GetTesteByIdAsync(int id);
}
