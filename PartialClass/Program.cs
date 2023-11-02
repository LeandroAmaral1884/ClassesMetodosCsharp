using _22PartialClass;


Console.WriteLine("## Partial Class ##\n");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em 07/08/2003\n");

var idade = minhaPartialClass.Calculadora(new DateTime(2003, 8 , 7));

Console.WriteLine($"{Math.Round(idade.TotalDays/365)} anos\n");

Console.WriteLine("Idade para os nacidos em 02/06/2005");

var data1=DateTime.Now;

var data2=new DateTime(2005,06,02);

var difereca = minhaPartialClass.DiferecaEntreDatas(data1, data2);

Console.WriteLine($"{Math.Round(difereca.TotalDays/365)}  anos");
Console.ReadKey();