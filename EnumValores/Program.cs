using _18Enumerations;

Console.WriteLine("## Enum Valores ##\n");

Console.WriteLine("Exibição normal\n");
Console.WriteLine(DiaDaSemana.Segunda);
Console.WriteLine("\nExibição usando Cast");

Console.WriteLine($"\n{DiaDaSemana.Quarta} vale:{(int)DiaDaSemana.Quarta}");
Console.WriteLine($"\n{DiaDaSemana.Quinta} vale:{(int)DiaDaSemana.Quinta}\n\n");

Console.WriteLine($"\n{DiaDaSemana.Domingo} vale:{(int)DiaDaSemana.Domingo}");
Console.WriteLine($"{Categorias.Moda}-{(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo}-{(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes}-{(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.livros}-{(int)Categorias.livros}");
Console.WriteLine($"{Categorias.Brinquedos}-{(int)Categorias.Brinquedos}\n\n");

Console.WriteLine("Selecione uma categoria:");
int valor = Convert.ToInt32(Console.ReadLine());

var numeroCategoria = (Categorias)valor;

Console.WriteLine("Você selecionou a categoria:" + numeroCategoria.ToString());




Console.ReadLine();

