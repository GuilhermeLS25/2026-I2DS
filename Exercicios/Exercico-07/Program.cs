internal class Program
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Tranqueiras do Pardal ===");

        List<Produto> listaProdutos = new List<Produto>();

        Produto produto1 = new Produto { ID = 1, Nome = "Jogo de Talheres", Preco = 24.90 };
        Produto produto2 = new Produto { ID = 2, Nome = "Xícara", Preco = 21.90 };
        Produto produto3 = new Produto { ID = 3, Nome = "Mochila Escolar", Preco = 55.95 };
        Produto produto4 = new Produto { ID = 4, Nome = "Pegador de Ovos", Preco = 11.62 };
        Produto produto5 = new Produto { ID = 5, Nome = "Carrinho de Feira", Preco = 53.84 };

        listaProdutos.Add(produto1);
        listaProdutos.Add(produto2);
        listaProdutos.Add(produto3);
        listaProdutos.Add(produto4);
        listaProdutos.Add(produto5);


        ImprimirLista(listaProdutos);
        
        var filtro = listaProdutos.Where(Prod => Prod.Preco >= 50).ToList();

        Console.WriteLine("=== Produtos selecionados pelo Filtro ===");

        ImprimirLista(filtro);
    }

    public static void ImprimirLista(List<Produto> lista)
    {
        Console.WriteLine();
        foreach (var Prod in lista)
        {
            Console.WriteLine($"| -> ID: {Prod.ID}\n| -> Nome: {Prod.Nome}\n| -> Preço: R${Prod.Preco}\n");
        }
    }
}
