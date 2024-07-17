namespace PG.Crossfit.Ranking.Dominio.Entidades;

public class Teste : EntidadeBase
{
    public string Nome { get; private set; }

    protected Teste() { }

    public Teste(string nome)
    {
        Nome = nome;
    }
}
