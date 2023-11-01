Console.WriteLine("## Construtor estático ##\n");
//Invocar construtor parametrizado e o estatico
Pessoa p1 = new Pessoa(19,"Maria");


Console.WriteLine($"  {p1.Nome}  {p1.Idade}");
Console.WriteLine("  Idade  Minima  " + Pessoa.IdadeMinima);

//;invocar somente o contrutor parametrizado
Pessoa p2 = new Pessoa(20, "Manoel");
Console.WriteLine($"  {p2.Nome}  {p2.Idade}");
Console.WriteLine("  Idade  Minima  " + Pessoa.IdadeMinima);

Console.ReadLine();
