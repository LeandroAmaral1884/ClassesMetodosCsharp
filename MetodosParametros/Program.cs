Console.WriteLine("## Metodos Parâmetros ##");
var nomeCliente = "Mario";
var dataAtual=DateTime.Now.ToLongDateString();
MinhaClasse minhaClasse = new MinhaClasse();
// valores do argumentos
minhaClasse.Saudacao("Leandro",DateTime.Now.ToLongDateString());
minhaClasse.Saudacao(nomeCliente,dataAtual) ;

Console.ReadLine();

class MinhaClasse
{

    //parametros do metodo
    public void Saudacao(string nome, string data)
    {

        Console.WriteLine(nome);
        Console.WriteLine(data);

    }

}