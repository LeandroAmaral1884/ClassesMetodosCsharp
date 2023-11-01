Console.WriteLine(" ## Atribuição da Struct ##");

MinhaCasse c1 = new MinhaCasse(), c2 = null;
MinhaStruct s1 = new MinhaStruct(), s2 = new();

c1.x = s1.x = 5;

c1.y = s1.y = 10;

c2 = c1;//referencia
s2 = s1;//valor

Console.WriteLine($" C1.X:{c1.x},S1.X{s1.x}\n C1.Y{c1.y}, S1.Y{s2.y} \n");
Console.WriteLine($" C2.X:{c2.x},S2.X{s2.x}\n C2.Y{c2.y}, S2.Y{s2.y} \n");

Console.ReadLine();
public class MinhaCasse
{
    public int x;
    public int y;

}
public struct MinhaStruct
{
    public int x;
    public int y;

}
