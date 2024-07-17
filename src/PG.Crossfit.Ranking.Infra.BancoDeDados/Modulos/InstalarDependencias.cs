using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Repository;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Repository.Interfaces;

namespace Microsoft.Extensions.DependencyInjection;

public static class InstalarDependencias
{
    public static void AdicionarServicosBanco(this IServiceCollection servicos, IConfiguration configuracoes)
    {
        servicos.TryAddScoped<IBaseRepository, BaseRepository>();
        servicos.TryAddScoped<ITesteRepository, TesteRepository>();
    }
}
