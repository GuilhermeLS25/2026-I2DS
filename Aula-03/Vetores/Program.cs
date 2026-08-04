internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Vetores e Matrizes
            Vetor => é uma estrutura de dados utilizada para armazenar
            varios valores de um mesmo tipo dentro de uma única variavel

            Sintaxe: int[] nome_vetor = new tipo[tamanho];
        
        */

        // Iniciar um vetor -> Lista de frutas

        string[] listaFrutas = {"Maçã","Manga","Morango","Melancia","Melão"};

        Console.WriteLine("Acessar o terceiro elemento da lista.");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Acessar o Segundo elemento da lista.");
        listaFrutas[1] = "Banana";

        for (int indice = 0; indice < listaFrutas.Length; indice++)
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        /* *********************************************************** */

        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }
    }
}