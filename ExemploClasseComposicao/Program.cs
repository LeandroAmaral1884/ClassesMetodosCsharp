using System;

Console.WriteLine(" Exemplo de Classe e sua composição \n");
Pessoa pessoa = new("Leandro",39);

pessoa.ExibirInformacoes();


Console.ReadLine();

// Definição da classe base "Pessoa"
class Pessoa
{
    // Atributos da classe
    private string nome;
    private int idade;

    // Construtor da classe "Pessoa"
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    // Método para exibir informações da pessoa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade}");
    }
}

