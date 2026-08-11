internal class Program
{
    private static void Main(string[] args)
    {
        Aluno Aluno1 = new Aluno();
        Aluno Aluno2 = new Aluno();
        Aluno Aluno3 = new Aluno();

        Aluno1.RM = 5191;
        Aluno2.RM = 5192;
        Aluno3.RM = 5193;

        Aluno1.Nome = "Guilherme Lima de Souza";
        Aluno2.Nome = "Davi Pedroza";
        Aluno3.Nome = "João Vitor Gimenez Gilo";

        Aluno1.Nascimento = new DateOnly(2008,09,25);
        Aluno2.Nascimento = new DateOnly(2009,08,08);
        Aluno3.Nascimento = new DateOnly(2008,03,29);

        Aluno1.Email = "ds.guilhermelima@gmail.com";
        Aluno2.Email = "davi.pedroza@gmail.com";
        Aluno3.Email = "jvggjvgg@gmail.com";

        Console.WriteLine($"\n| Aluno: {Aluno1.Nome} \n| RM: {Aluno1.RM} \n| Nascimento: {Aluno1.Nascimento} \n| Email: {Aluno1.Email}");
        Console.WriteLine($"\n| Aluno: {Aluno2.Nome} \n| RM: {Aluno2.RM} \n| Nascimento: {Aluno2.Nascimento} \n| Email: {Aluno2.Email}");
        Console.WriteLine($"\n| Aluno: {Aluno3.Nome} \n| RM: {Aluno3.RM} \n| Nascimento: {Aluno3.Nascimento} \n| Email: {Aluno3.Email}");

    }

    public class Aluno
    {
        public int RM { get; set; }
        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public string Email { get; set; }

    }
}