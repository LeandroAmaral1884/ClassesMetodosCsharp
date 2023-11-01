
Console.WriteLine("## ----Carro-----------##\n");

Carro chevrolet = new("Sedan", "Chevrolet",110);

Console.WriteLine($"{chevrolet.Modelo} , {chevrolet.Montadora} {chevrolet.Potencia} = {chevrolet.VelocidadeMaxima()} \n\n");
Carro ford = new("SUV", "Ford",120);


Console.WriteLine($"{ford.Modelo}, {ford.Montadora} {ford.Potencia} = {ford.VelocidadeMaxima()}");

Console.ReadLine();

class Carro
{
    public string? Modelo;
    public string? Montadora;
    public double Potencia ;
    public double VelocidadeMaxima()
    {

  
        return Potencia= Potencia * 1.75f;
    }

    public  Carro (string? modelo, string? montadora, double potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Potencia = potencia;
    }


    

}
