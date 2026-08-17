internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== HISTORICO DE AÇÕES ===");

        Stack<string> Historico = new Stack<string>();

        Historico.Push("Digitar");
        Historico.Push("Colar");
        Historico.Push("Negrito");
        Historico.Push("Apagar");

        foreach (var item in Historico)
        {
            Console.WriteLine($"| -> {item}");
        }

        Console.WriteLine("==========================");


        string acao1 = Historico.Pop();
        Console.WriteLine();
        Console.WriteLine($"A Ação foi desfeita: {acao1}");

        string acao2 = Historico.Pop();
        Console.WriteLine($"A Ação foi desfeita: {acao2}");
        Console.WriteLine();

        foreach (var item in Historico)
        {
            Console.WriteLine($"| -> {item}");
        }

        Console.WriteLine("==========================");
    }
}