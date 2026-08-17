internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("      CLÍNICA DE SAÚDE — PAINEL DE ATENDIMENTO   ");
        Console.WriteLine("==================================================");

        Queue<string> filaClinica = new Queue<string>();

        filaClinica.Enqueue("Guilherme");
        filaClinica.Enqueue("Davi");
        filaClinica.Enqueue("João");
        filaClinica.Enqueue("Bruno");
        filaClinica.Enqueue("Gustavo");

        string pessoaSala13 = filaClinica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"| CHAMADA: {pessoaSala13} ➔ Consultório: SALA 13");
        Console.WriteLine("\n| Pacientes aguardando na fila:");

        foreach (var pessoa in filaClinica)
        {
            Console.WriteLine($"|  ▪ {pessoa}");
        }

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("             ATUALIZAÇÃO DA FILA                 ");
        Console.WriteLine("--------------------------------------------------");

        string pessoaSala22 = filaClinica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"| CHAMADA: {pessoaSala22} ➔ Consultório: SALA 22");
        Console.WriteLine("\n| Pacientes aguardando na fila:");

        foreach (var pessoa in filaClinica)
        {
            Console.WriteLine($"|  ▪ {pessoa}");
        }
        Console.WriteLine();
    }
}