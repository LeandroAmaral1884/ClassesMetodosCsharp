using System.Runtime.Serialization;

Console.WriteLine("##   Metodos com Retorno ##");
Calculadora calculadora = new Calculadora();
Console.WriteLine($"{calculadora.Soma(10,10)}\n");
Console.WriteLine($"{calculadora.Subtrair(10, 10)}\n");
Console.WriteLine($"{calculadora.Dividir(10, 10)}\n");
Console.WriteLine($"{calculadora.Multiplicar(10, 10)}\n");
Console.ReadKey();


public class Calculadora
{
    public int Soma(int n1, int n2)
    { return n1 + n2; }
    public int Subtrair(int n1, int n2)
    { return n1 - n2; }

    public int Multiplicar(int n1, int n2)
    { return n1 * n2; }

    public int Dividir(int n1, int n2)
    { return n1 / n2; }
}
