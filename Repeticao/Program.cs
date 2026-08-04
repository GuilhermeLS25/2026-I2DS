internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Sintaxe:

                Enquanto uma condição for verdadeira
                    Execute um conjunto de comandos

            for -> Quando sabemos a quantidade de repetições.
            while -> Quando a repetição depende de uma condição.
            do ... while -> Quando precisa executar aoi menos uma 
                            vez o bloco de código.
        */

        // Laço For: Imprimir nuimeors de 1 até o 10

        int numeros = 1;

        Console.WriteLine("Imprimir numeros de 1 até 10, utilizandoo laço for.");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}