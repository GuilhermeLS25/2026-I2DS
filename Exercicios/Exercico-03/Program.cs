internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Bem-Vindo ao 👑 Burger Ring 🍔 ===");
        Console.WriteLine("|");


        Dictionary<int, string> Cardapio = new Dictionary<int, string>();

        Cardapio.Add(1, "Whopper");
        Cardapio.Add(2, "Batata Frita");
        Cardapio.Add(3, "Coca-Cola");
        Cardapio.Add(4, "Casquinha");

        foreach (var item in Cardapio)
        {
            Console.WriteLine($"| -> {item.Key} - {item.Value}");
        }

        Console.WriteLine("=====================================");
        
    }
}