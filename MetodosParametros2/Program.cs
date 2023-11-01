Console.WriteLine("## Métodos - Parâmetros");

Aluno aluno = new Aluno();
aluno.Consultar();
Console.ReadLine();

///classe aluno  com atributos:nome,idade,sexo, aprovado
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {

        var aluno = new Aluno();


        Console.WriteLine("Nome:");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo:");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado:(S)im (N)ão:");
        aluno.Aprovado = Console.ReadLine();
        Curso curso = new Curso();
        ////recebe aluno
        curso.Resultado(aluno);




    }
}
///classe curso com metodo publico Resultado com parametros:nome,idade,sexo, 
///aprovado ou para ficar curto Recebe objeto Aluno do tipo aluno
public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($" O aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "s")
        { Console.WriteLine("\nFoi aprovado!!!!"); }
        else { Console.WriteLine("\n Reprovado"); }
    }

}