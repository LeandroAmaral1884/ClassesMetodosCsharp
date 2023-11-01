using System.Runtime.CompilerServices;

Console.WriteLine("## Classes e Métodos##\n");

Pessoa p1 = new()
{
    nome = "Leandro",
    idade = 39,
    sexo = "Masculino"
};

Pessoa p2 = p1;
/*Pessoa p2 = new Pessoa();
p2.nome = "Mateus";
p2.idade = 39;
p2.sexo = "Masculino";*/
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");
Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Console.ReadLine();


class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
