Console.WriteLine(" ## Utlização da Struct ##");

Cliente cliente = new Cliente();
cliente.Nome = "Maria";
cliente.Idade = 10;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");


Console.ReadLine();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }


    public Cliente( string nome, int idade)
    {
        Nome=nome;
        Idade = idade;

    }
}
