using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PG.Crossfit.Ranking.Dominio.Entidades;

namespace PG.Crossfit.Ranking.Infra.BancoDeDados.Mapeamentos;

internal class TesteMap : BaseMap<Teste>
{
    public TesteMap() : base("teste") { }

    public override void Configure(EntityTypeBuilder<Teste> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Nome).HasColumnName("nome");
    }
}
