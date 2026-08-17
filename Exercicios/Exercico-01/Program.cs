internal class Program
{
    public class Cidade
    {
        public string? Nome { get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TOP CIDADES MARAVILHOSAS ===");
        Console.WriteLine("|");


        List<Cidade> listaCidades = new List<Cidade>();

        Cidade Cidade1 = new Cidade{Nome = "Jaú"};
        Cidade Cidade2 = new Cidade{Nome = "Itajú"};
        Cidade Cidade3 = new Cidade{Nome = "Suzano"};
        Cidade Cidade4 = new Cidade{Nome = "Bauru"};
        Cidade Cidade5 = new Cidade{Nome = "Campinas"};

        listaCidades.Add(Cidade1);
        listaCidades.Add(Cidade2);
        listaCidades.Add(Cidade3);
        listaCidades.Add(Cidade4);
        listaCidades.Add(Cidade5);

        foreach (var item in listaCidades)
        {
            Console.WriteLine($"| -> {item.Nome}");
        }

        Console.WriteLine("================================");

    }
}