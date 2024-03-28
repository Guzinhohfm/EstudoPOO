using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.altura = 1.73;
        pessoa.peso = 87;
        pessoa.retornaIMC();
    }
}