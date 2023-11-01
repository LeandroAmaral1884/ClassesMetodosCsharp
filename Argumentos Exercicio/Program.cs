Console.WriteLine(" ##   Exercicio Argumentos ##");

Carro carro = new Carro();

Console.WriteLine("Digite ano:");
int ano = Convert.ToInt32(Console.ReadLine());

carro.ExibirInf(modelo: "Fire", montadora: "Fiat", "Uno", 1.75, 1990);
carro.ExibirInf(modelo:"Fire", montadora:"Fiat","Uno",1.75,ano);
carro.ExibirInf(modelo: "Fire", montadora: "Fiat", "Uno", 1.75);

Console.ReadLine();

public class Carro
{

    public void ExibirInf(string modelo = "padrão",string montadora = "padrão",string marca = "padrão",double potencia = 0.00,int ano = 0000)
    {
        Console.WriteLine($"{modelo} {montadora} {marca} {potencia} {ano}");
    }
    public void ExibirInf(string modelo = "padrão", string montadora = "padrão", string marca = "padrão", double potencia = 0.00)
    {
        Console.WriteLine($"{modelo} {montadora} {marca} {potencia}");
    }
}
