using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class InstalarDependencias
{
    public static void AdicionarMediadores(this IServiceCollection servicos, IConfiguration configuracoes)
    {
        //servicos.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ReplicarRelatorioPeriodicoVendaHandler).Assembly));

        servicos.AdicionarServicos(configuracoes);
    }
}