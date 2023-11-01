
public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\n Executando o construtor parametrizado");
        Idade = idade;
        Nome = nome;

    }
    public Pessoa()
    {

    }

    static Pessoa()
    {
        Console.WriteLine("\n Executando o construtor estático");
        Console.WriteLine("\n Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}