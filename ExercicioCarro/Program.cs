﻿
Console.WriteLine("## ----Carro-----------##\n");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016,110);


chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"{chevrolet.Modelo} , {chevrolet.Montadora}, {chevrolet.Marca}, {chevrolet.Ano} e {chevrolet.Potencia} CV\n\n");
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

ford.Acelerar(ford.Marca);
Console.WriteLine($"{ford.Modelo}, {ford.Montadora} , {ford.Marca} , {ford.Ano} e {ford.Potencia} CV");

Console.ReadLine();

class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;




    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar(string marca)
    {
        
        
        Console.WriteLine("Acelerando...." + marca);
        

    }

    
       



   
        
    
}