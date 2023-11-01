
Console.WriteLine(" Exemplo Método\n");

MinhaClasse minhaClasse = new();

// Chamando o método MeuMetodo (sem parâmetros)
minhaClasse.Saudacao();
minhaClasse.DataAtual();

Console.ReadKey();

class MinhaClasse
{
    // Chamando o método MeuMetodo (sem parâmetros)
    public void Saudacao()
    {
        Console.WriteLine("Crei a classe....");
        DataAtual();
    }
    // Chamando o método MeuMetodo (sem parâmetros)
    public void DataAtual() =>
     Console.WriteLine(DateTime.Now.ToLongDateString());
}