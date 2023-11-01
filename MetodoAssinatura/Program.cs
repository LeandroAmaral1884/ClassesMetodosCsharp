Console.WriteLine("##  Metodo Assunatura ##");
Email email = new Email();
email.Enviar("empresa.com");
email.Enviar("empresa.com","Proposta Comercial");
email.Enviar("empresa.com",2000);
email.Enviar(2000, "empresa.com");



Console.ReadLine();

 public class Email
{
   public void Enviar( string endereco)
    {

        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto padrão");

    }
    public void Enviar(string endereco,string assunto)
    {

        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");

    }
    public void Enviar(string endereco, decimal valor)
    {

        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto comercial");
        Console.WriteLine($"{valor}");

    }

    public void Enviar(decimal valor,string endereco )
    {

        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento comercial");
        Console.WriteLine($"{valor}");

    }
}