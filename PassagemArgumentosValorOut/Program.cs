Console.WriteLine("## Passagem por argumento valor OUT ##");

Console.WriteLine(" Informe o raio do circulo:");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double perimetro = circulo.CalcularAreaPerimetro(raio, out double area);

Console.WriteLine(" Perimetro da Circuferencia :" + perimetro);
Console.WriteLine(" Área da Circuferencia :" + area);




Console.ReadLine();

public class Circulo
{
    public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

}