Console.WriteLine("## Métodos ##");

MinhaClasse minhaClasse = new();


minhaClasse.Saudacao();
minhaClasse.DataAtual();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Crei a classe....");
        DataAtual();
    }

    public void DataAtual()=>
     Console.WriteLine(DateTime.Now.ToLongDateString()); 
}