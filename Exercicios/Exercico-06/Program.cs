internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int, int> somarSalas = (num1, num2) => num1 * num2;

        int num1 = 13;
        int num2 = 22;
        int total = somarSalas(num1, num2);

        Console.WriteLine("\n=== Trabalhando com Multiplicação ===");
        Console.WriteLine($"| A multiplicação de {num1} e {num2} é Igual a {total}");
        Console.WriteLine("=====================================\n");
    }
}