Console.WriteLine("## Tratando TRY e Cath e Finally ## \n");
Console.WriteLine("X / Y");


try
{
    Console.WriteLine("Informe valor X:");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme valor Y:");
    int y = Convert.ToInt32(Console.ReadLine());

    int z = x / y;

    Console.WriteLine($"\nResultado {x}/{y} = {z}");
    Console.WriteLine($"\nResultado {x}/{y} = {z}");


}
catch (Exception ex)
{
    Console.WriteLine("\nErro na divisão por 0 )");
    Console.WriteLine($"\n Erro:<<<{ex.Message}>>>>");
    Console.WriteLine($"\n DEtalhes : {ex?.StackTrace?.ToString()}");

}
finally
{ Console.WriteLine("\nFim do processo"); }




Console.ReadLine();
