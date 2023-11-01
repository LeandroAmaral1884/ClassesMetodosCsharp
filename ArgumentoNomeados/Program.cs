

Console.WriteLine("## Argumentos Nomeados\n ##");

Email email = new Email();

Console.WriteLine("Digite email:");

//argumentos nomeados
email.Enviar(destino: "amaralsia.com", titulo: "CODE", assunto: " bom dia");

Console.ReadKey();

public class Email
{
    //ar
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\n Email :{destino} - Titulo : {titulo} \n Assnto :{assunto} ");
    }
}