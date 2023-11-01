Console.WriteLine("## Exercicio argumento valor ##");

int x = 20;
Console.WriteLine("\nValor do argumento  x antes de passar valor:" + x);

Calculo calculo = new Calculo();
calculo.Dobrar(x);

Console.WriteLine("\nValor do argumento  x depois de passar valor:" + x);

Console.ReadLine();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 3;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar:" + y);
    }
}