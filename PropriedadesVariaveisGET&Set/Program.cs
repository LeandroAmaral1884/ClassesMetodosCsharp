Console.WriteLine("\n ##  Propriedades GET e SET ##");

Produto p1 = new Produto();
p1.Nome = "Caderno Espiral capa dura";
p1.Preco = 4.99;


p1.EstoqueMinimo = 10;


p1.Exibir();

Console.ReadLine();

public class Produto
{
    private string nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }
    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }
    private double desconto = 0.05;
    public double Desconto { get { return desconto; } }
    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }
    private int minimo;
    public int EstoqueMinimo {

        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($" Produto:{Nome}\n " +
            $"Preço:{Preco.ToString("c")}\n " +
            $"Desconto:{Desconto}\n " +
            $"Preço Final:{PrecoFinal.ToString()} \n " +
            $"Estoque Minimo :{minimo}");
    }

}

