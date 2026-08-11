internal class Program
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorEstoque()
        {
            return Preco * Quantidade;
        }
    }
    private static void Main(string[] args)
    {
        // Primeiro Produto
        Produto produto1 = new Produto();
        produto1.Codigo = 1001;
        produto1.Nome = "Teclado";
        produto1.Preco = 120.00;
        produto1.Quantidade = 10;

        // Primeiro Produto
        Produto produto2 = new Produto();
        produto2.Codigo = 1002;
        produto2.Nome = "Mouse";
        produto2.Preco = 80.00;
        produto2.Quantidade = 10;

        // Primeiro Produto
        Produto produto3 = new Produto();
        produto3.Codigo = 1003;
        produto3.Nome = "Monitor";
        produto3.Preco = 800.00;
        produto3.Quantidade = 10;

        Console.WriteLine($"\n| Produto: {produto1.Nome} \n| Codigo: {produto1.Codigo} \n| Preço: {produto1.Preco} \n| Quantidade: {produto1.Quantidade}");
        Console.WriteLine($"\n| Produto: {produto2.Nome} \n| Codigo: {produto2.Codigo} \n| Preço: {produto2.Preco} \n| Quantidade: {produto2.Quantidade}");
        Console.WriteLine($"\n| Produto: {produto3.Nome} \n| Codigo: {produto3.Codigo} \n| Preço: {produto3.Preco} \n| Quantidade: {produto3.Quantidade}");

    }
}