using System; //importando biblioteca system

internal class Program
{
    private static void Main(string[] args)
    {
        //Instanciar um objeto
        Pessoa obj = new Pessoa();

        obj.nome = "Gustavo";
        obj.idade = 20;
        obj.Mensagem();
    }
}