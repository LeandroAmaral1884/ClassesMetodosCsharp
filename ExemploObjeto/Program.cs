Console.WriteLine(" Exemplo de Objeto \n");

// Criando objetos
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 30;

Pessoa pessoa2 = new Pessoa { Nome = "Maria", Idade = 25 };

// Acessando propriedades e métodos
Console.WriteLine($"Nome da pessoa1: {pessoa1.Nome}");
Console.WriteLine($"Idade da pessoa2: {pessoa2.Idade}");

pessoa1.Cumprimentar();
pessoa2.Cumprimentar();

Console.ReadLine();







public class Pessoa
{
    // Propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Métodos
    public void Cumprimentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}


