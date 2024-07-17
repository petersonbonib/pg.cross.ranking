using PG.Crossfit.Ranking.Infra.BancoDeDados.Contextos;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Repository.Interfaces;

namespace PG.Crossfit.Ranking.Infra.BancoDeDados.Repository;

internal class BaseRepository : IBaseRepository
{
    private readonly RankingContexto _context;

    public BaseRepository(RankingContexto context)
    {
        _context = context;
    }

    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }
}
