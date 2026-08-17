internal class Program
{
    public class Funcionario
    {
        public DateOnly Matricula { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
    }
    private static void Main(string[] args)
    {
        Dictionary<int , Funcionario> dicionario = new Dictionary<int, Funcionario>();
    }
}