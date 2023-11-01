Console.WriteLine("## Tipo Anônimo ##\n");





var aluno = new
{
    Id = 1,
    Nome = "Maria",
    Idade = 42,
    Endereco = new { Id = 1,Cidade="CXS",Pais="BR"}
};
Console.WriteLine(aluno.Nome + "-" + aluno.Idade);
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

Console.WriteLine("\n Array");
var alunos = new[] {
new{Id=1,Nome="Leandro",Idade=33},
new { Id = 2, Nome = "Marcos", Idade = 35 },
new{Id=3,Nome="Pedro",Idade=39}
};


Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Idade);
