using Microsoft.EntityFrameworkCore;
using PG.Crossfit.Ranking.Dominio.Entidades;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Contextos;

namespace PG.Crossfit.Ranking.Infra.BancoDeDados.Repository.Interfaces;

internal class TesteRepository : BaseRepository, ITesteRepository
{
    private readonly RankingContexto _context;

    public TesteRepository(RankingContexto context) : base(context)
    {
        _context = context;
    }

    public async Task<Teste> GetTesteByIdAsync(int id)
    {
        return await _context.Testes.Where(x => x.Id == id).FirstOrDefaultAsync();
    }
}
