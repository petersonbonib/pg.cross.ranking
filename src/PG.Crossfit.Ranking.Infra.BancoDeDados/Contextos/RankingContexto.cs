using Microsoft.EntityFrameworkCore;
using PG.Crossfit.Ranking.Dominio.Entidades;

namespace PG.Crossfit.Ranking.Infra.BancoDeDados.Contextos;

public class RankingContexto : DbContext
{
    public RankingContexto(DbContextOptions<RankingContexto> options) : base(options)
    { }

    public DbSet<Teste> Testes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var teste = modelBuilder.Entity<Teste>();

        teste.ToTable("teste");
        teste.HasKey(x => x.Id);
        teste.Property(x => x.Id).HasColumnName("id");
        teste.Property(x => x.Nome).HasColumnName("nome");
    }
}
