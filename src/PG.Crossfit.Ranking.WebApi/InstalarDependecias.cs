using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class InstalarDependecias
{
    public static void AdicionarServicosApi(this IServiceCollection servicos, IConfiguration configuracao)
    {
        servicos.AdicionarMediadores(configuracao);
    }

    private static void AdicionarConversores(this IServiceCollection servicos)
    {
        
    }
}