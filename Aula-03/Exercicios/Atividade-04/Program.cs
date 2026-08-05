internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("             BANCO ZLBank S.A.             ");
        Console.WriteLine("===========================================");
        Console.WriteLine("");

        Console.Write("Valor a ser Sacado: ");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");

        int notas100 = valor / 100;
        valor %= 100;

        int notas50 = valor / 50;
        valor %= 50;

        int notas20 = valor / 20;
        valor %= 20;

        int notas10 = valor / 10;
        valor %= 10;

        int notas5 = valor / 5;
        valor %= 5;

        int notas1 = valor;

        Console.WriteLine($"R$ 100,00 - {notas100} notas");
        Console.WriteLine($"R$ 50,00  - {notas50} notas");
        Console.WriteLine($"R$ 20,00  - {notas20} notas");
        Console.WriteLine($"R$ 10,00  - {notas10} notas");
        Console.WriteLine($"R$ 5,00   - {notas5} notas");
        Console.WriteLine($"R$ 1,00   - {notas1} notas");
        Console.WriteLine("");
        Console.WriteLine("Obrigado por utilizar o Banco ZLBank!");
        Console.WriteLine("===========================================");
    }
}
