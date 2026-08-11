internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Livro
        Livro Livro1 = new Livro();
        Livro1.Titulo = "O Senhor dos Aneis";
        Livro1.Autor = "J.R.R. Tolkien";
        Livro1.Editora = "HarperCollins";
        Livro1.AnoLancamento = 1954;

        // Segundo Livro
        Livro Livro2 = new Livro();
        Livro2.Titulo = "Harry Potter e a Pedra Filosofal";
        Livro2.Autor = "J.K. Rowling";
        Livro2.Editora = "Rocco";
        Livro2.AnoLancamento = 1997;

        // Terceiro Livro
        Livro Livro3 = new Livro();
        Livro3.Titulo = "Dom Casmurro";
        Livro3.Autor = "Machado de Assis";
        Livro3.Editora = "Garnier";
        Livro3.AnoLancamento = 1899;

        // Exibindo os Livros na tela
        Console.WriteLine("==== Livros ====");
        Console.WriteLine($"\nLivro 01: {Livro1.Titulo} | Autor: {Livro1.Autor}");
        Console.WriteLine($"\nLivro 02: {Livro2.Titulo} | Autor: {Livro2.Autor}");
        Console.WriteLine($"\nLivro 03: {Livro3.Titulo} | Autor: {Livro3.Autor}");

    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoLancamento { get; set; }
    }
}