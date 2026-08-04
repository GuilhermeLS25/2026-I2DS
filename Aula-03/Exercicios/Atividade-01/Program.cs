internal class Program
{
    private static void Main(string[] args)
    {
        double Celsius = 0;
        double Fahrenheit = 0;

        Console.WriteLine("===========================================");
        Console.Write("Digite a temperatura em Celsius: ");

        Celsius = double.Parse(Console.ReadLine());        
        Fahrenheit = (Celsius * 9 / 5) + 32;

        Console.WriteLine("===========================================");
        Console.WriteLine($"{Celsius}°C equivalem a {Fahrenheit}°F");
        Console.WriteLine("===========================================");
    }
}