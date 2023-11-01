using _Cores;
Console.WriteLine(" ## Exercicio Enum ##\n");
while (true)
{

    Carros carros = new Carros(); ;

    Console.WriteLine($"{CoresCarros.Branco} - {(int)CoresCarros.Branco}");
    Console.WriteLine($"{CoresCarros.Vermelho} - {(int)CoresCarros.Vermelho}");
    Console.WriteLine($"{CoresCarros.Preto} - {(int)CoresCarros.Preto}");
    Console.WriteLine($"{CoresCarros.Prata} - {(int)CoresCarros.Prata}");
    Console.WriteLine($"{CoresCarros.Azul} - {(int)CoresCarros.Azul}");

    Console.WriteLine("Selecione a cor do veiculo DIGITE 99 PARA SAIR:\n");
    int valor = Convert.ToInt32(Console.ReadLine());
/*    var corCarros = (CoresCarros)valor;*/
    if (valor == 99)
    {
        Console.WriteLine("Acabou as escolhas.\n");
        break;
       
    }

        carros.ExebirInf(valor);
}


Console.WriteLine("Fim do processo\n");


Console.ReadLine();


public class Carros
{
    //campo 
    public int Cor;

    //construtor
    public Carros(int cor = 0 )
    {
        Cor= cor;
    }
    //método 
    public void ExebirInf(int cor=0)
    {
        Console.WriteLine($"Cor selecionada: {(CoresCarros)cor}");
    }
}