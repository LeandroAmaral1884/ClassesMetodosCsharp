Console.WriteLine(" ##   Exercicio Argumentos ##");

Carro carro = new Carro();

Console.WriteLine("Digite ano:");
carro.Ano = Convert.ToInt32(Console.ReadLine());


carro.ExibirInf(modelo: "Fire", montadora: "Fiat", "Uno", 1.75);


Console.ReadLine();

public class Carro
{
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }

    public void ExibirInf(string modelo = "padrão", string montadora = "padrão", string marca = "padrão", double potencia = 0.00)
    {
        Console.WriteLine($"{modelo} {montadora} {marca} {potencia} {ano} ");
    }

}
