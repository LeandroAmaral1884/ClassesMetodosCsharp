Console.WriteLine(" Exemplo de Prametro de Metodo\n");

MinhaClasse minhaClasse = new MinhaClasse();



Console.WriteLine(minhaClasse.Soma(12, 12));

Console.ReadLine();

public class MinhaClasse
{
    // Este é um método que aceita dois parâmetros: a e b
    public int Soma(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
}
