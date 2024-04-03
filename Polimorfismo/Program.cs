internal class Program
{
    private static void Main(string[] args)
    {
        
        Imposto estagiario = new Estagiario();
        estagiario.valeAlimentacao(1000);
        estagiario.valeTransporte(1000);
        Console.WriteLine("-----------------");

        Imposto gerente = new Gerente();
        gerente.valeAlimentacao(5000);
        gerente.valeTransporte(5000);
        Console.WriteLine("-----------------");

        Imposto atendente = new Atendente();
        atendente.valeAlimentacao(3000);
        atendente.valeTransporte(3000);
        Console.WriteLine("-----------------");
    }
}