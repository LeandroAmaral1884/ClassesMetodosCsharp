Console.WriteLine(" Exemplo de Diferença Classe e Objeto \n");

// Classe: Definição da classe Pessoa
// Define a estrutura da classe, mas não cria objetos reais.

// Objeto 1: Criando uma instância da classe Pessoa
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 30;

// Objeto 2: Criando outra instância da classe Pessoa
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Idade = 25;

// Cada objeto é uma instância única da classe Pessoa.
Console.WriteLine($"Objeto 1 - Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
Console.WriteLine($"Objeto 2 - Nome: {pessoa2.Nome}, Idade: {pessoa2.Idade}");

Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}


