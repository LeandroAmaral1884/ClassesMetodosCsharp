Console.WriteLine("## Passagem por argumento valor REF ##");

int x = 20;
Console.WriteLine("\nValor do argumento  x antes de passar valor:" + x);

Calculo calculo = new Calculo();
calculo.Dobrar(ref x);

Console.WriteLine("\nValor do argumento  x depois de passar valor:" + x);

Console.ReadLine();

public class Calculo
{
    public void Dobrar( ref int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar:" + y);
    }
}