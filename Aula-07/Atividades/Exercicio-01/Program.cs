internal class Program
{
    public class Frutas
    {
        public string? Nome { get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("\n======== Bem-Vindo a Feira ========");
        Console.WriteLine("| -> Frutas Disponiveis");
        Console.WriteLine("|");
        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas fruta1 = new Frutas { Nome = "Goiaba" };
        Frutas fruta2 = new Frutas { Nome = "Manga" };
        Frutas fruta3 = new Frutas { Nome = "Abacate" };
        Frutas fruta4 = new Frutas { Nome = "Melancia" };
        Frutas fruta5 = new Frutas { Nome = "Maçã" };

        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2);
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);


        // Exibir todas as frutas cadastradas.
        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"| ->{item.Nome}");
        }
        Console.WriteLine("================================");


        // Solicitar ao usuário uma nova fruta.
        Console.WriteLine("Adicione uma Fruta: ");
        Frutas fruta6 = new Frutas { Nome = Console.ReadLine() };
        listaFrutas.Add(fruta6);


        // Exibir novamente a lista atualizada.
        Console.WriteLine("| -> Frutas Atualizadas!!");
        Console.WriteLine("|");
        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"| ->{item.Nome}");
        }
        Console.WriteLine("================================");
    }
}