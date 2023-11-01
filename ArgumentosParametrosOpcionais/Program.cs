Console.WriteLine("## Argumentos Parametros Opcionais\n ##");

Email email = new Email();

Console.WriteLine("Digite Destino:");
var destino = Console.ReadLine();
Console.WriteLine("Digite Titulo:");
var titulo = Console.ReadLine();
Console.WriteLine("Digite Assunto:");
var assunto = Console.ReadLine();
email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);
email.Enviar(destino: destino, assunto);

Console.ReadKey();

public class Email
{
    //ar
    public void Enviar(string destino = "Padrãp", string titulo="Padrão", string assunto = "Padrão")
    {
        Console.WriteLine($"\n Email :{destino} - Titulo : {titulo} \n Assunto :{assunto} ");
    }
}