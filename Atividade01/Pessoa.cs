using System;
class Pessoa
{
    public double peso, altura;

    public double calcularIMC()
    {
     double imc = peso / (altura * altura);

    return Math.Round(imc - .005 , 2);
        //Calculará IMC e retornará ele
    }    

    public void retornaIMC()
    {
        string mensagem;
        double obterIMC = calcularIMC();

        if (obterIMC <= 18.5)
        {
          mensagem = "Abaixo do peso";
        }
        else if (obterIMC < 25)
        {
          mensagem = "Peso normal";
        }
        else if(obterIMC < 30)
        {
         mensagem = "Acima do peso";
        }
        else 
        {
           mensagem = "Obesidade";
        }

        Console.WriteLine("A pessoa de "+peso+"kg e altura de "+altura+" com IMC de "+ obterIMC+ " é "+mensagem);
    }
    
}