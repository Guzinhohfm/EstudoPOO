using System;
class Pessoa
{
    private string nome = "João";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}