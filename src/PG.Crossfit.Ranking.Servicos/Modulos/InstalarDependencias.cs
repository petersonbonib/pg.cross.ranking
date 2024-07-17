using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PG.Crossfit.Ranking.Dominio.Interfaces;
using PG.Crossfit.Ranking.Servicos.Servicos;

namespace Microsoft.Extensions.DependencyInjection;

public static class InstalarDependencias
{
    public static void AdicionarServicos(this IServiceCollection servicos, IConfiguration configuracoes)
    {
        servicos.TryAddScoped<ITesteServico, TesteServico>();

        servicos.AdicionarServicosBanco(configuracoes);
    }
}