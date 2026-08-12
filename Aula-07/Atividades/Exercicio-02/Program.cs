internal class Program
{
    public class Aluno
    {
        public int Idade { get; set; }
        public string? Nome { get; set; }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== 02 - Cadastro de Alunos ===");

        // Lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno { Idade = 12, Nome = "Zuleika" };
        Aluno aluno2 = new Aluno { Idade = 14, Nome = "Pafúncio" };
        Aluno aluno3 = new Aluno { Idade = 12, Nome = "Asdrúbal" };

        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);

        // 1. Exibir todos os alunos.
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"| ->{item.Nome} - {item.Idade}");
        }
        Console.WriteLine("================================");

        // 2. Permitir alterar a idade de um aluno.
        listaAlunos[1].Idade = 15;
        Console.WriteLine();
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"| ->{item.Nome} - {item.Idade}");
        }
        Console.WriteLine("================================");


        // Remover um elemento da lista por objeto 
        listaAlunos.Remove(aluno3);
        Console.WriteLine();
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"| ->{item.Nome} - {item.Idade}");
        }
        Console.WriteLine("================================");
    }
}