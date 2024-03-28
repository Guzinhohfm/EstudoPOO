using System;

class Pessoa
{
    // Metodo 01
    public void apresentar()
    {
      Console.WriteLine("Ola");
    }

    //Metodo 02
    public void apresentar(string nome)
    {
      Console.WriteLine("Ola " + nome);
    }

    //Metodo 03
    public void apresentar(string nome, int idade)
    {
      Console.WriteLine("Olá "  +nome+ ",você tem " +idade+ " anos");
    }
}