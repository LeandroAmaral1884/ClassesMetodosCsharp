Console.WriteLine("## Exercicio Struct ##\n");

Cliente cliente = new("Maria","Maria@.com.br",17);
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);


Console.WriteLine("\nExibindo informação sem informar a idade");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);





Console.ReadLine();



public struct Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }

    private int idade;
    public  int Idade
    {

        get { return idade; }

        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("\nMenor de Idade");
            }
            else
            {
                Console.WriteLine("\nMaior de Idade");
                idade = value;
            }


        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }


    public static void ExibirInfo(string nome, string email, int idade=18)
    {


        Console.WriteLine($"{nome}  {email}  {idade} ");
    }


    public static void ExibirInfo(string nome, string email)
    {


        Console.WriteLine($"{nome}  {email}  ");
    }


}