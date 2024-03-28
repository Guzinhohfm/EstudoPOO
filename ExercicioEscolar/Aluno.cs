using System;

class Aluno
{

    //Atributos
    public string? nome;
    public double nota1, nota2;

    //Metodos

    public double Media()
    {
        return (nota1+nota2)/2;
    }

    public string Situacao(double media)
    {
        return media >= 6 ? "aprovado" : "reprovado";
    }

    public void Mensagem()
    {
        double obterMedia = Media();

        string obterSituacao = Situacao(obterMedia);

        Console.WriteLine("A situação do aluno "+ nome + " é: " + obterSituacao + " com nota " + obterMedia);
    }




}