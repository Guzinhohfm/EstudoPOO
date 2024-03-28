using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //Instanciando objeto de classe Aluno
        Aluno aluno = new Aluno();

        aluno.nome = "João";
        aluno.nota1 = 8;
        aluno.nota2 = 10;    
        aluno.Mensagem();
    }
}