using System;

class Colaborador : Pessoa
{
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.salario = salario;
        this.nome = nome;
        this.idade = idade;

        mensagemPessoa();
        mensagemColaborador();
    }
    private void mensagemColaborador()
    {
        Console.WriteLine("salario= "+salario);

    }
}