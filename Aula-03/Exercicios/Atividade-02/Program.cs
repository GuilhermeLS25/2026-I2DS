internal class Program
{
    private static void Main(string[] args)
    {
        double num1;
        double num2;
        double math;

        Console.WriteLine("===========================================");
        Console.Write("Número 1: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("===========================================");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("1 - Divisão");
        Console.WriteLine("===========================================");


        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                math = num1 + num2;
                Console.WriteLine($"A soma do {num1} e {num2} é igual a {math}");
                break;
            case 2:
                math = num1 - num2;
                Console.WriteLine($"A subtração do {num1} e {num2} é igual a {math}");
                break;
            case 3:
                math = num1 * num2;
                Console.WriteLine($"A multiplicação do {num1} e {num2} é igual a {math}");
                break;
            case 4:
                math = num1 / num2;
                Console.WriteLine($"A divisão do {num1} e {num2} é igual a {math}");
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
        Console.WriteLine("===========================================");

    }
}