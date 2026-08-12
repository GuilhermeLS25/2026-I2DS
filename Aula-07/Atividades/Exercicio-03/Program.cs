internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====== LISTA DE CONTATOS ======");
        
        // 1. Cadastrar um contato.
        Dictionary<string, string> dicionario = new Dictionary<string, string>();
        dicionario.Add("Pai", "(+14) 1 2345-6789");
        dicionario.Add("Mae", "(+14) 1 2345-6789");
        dicionario.Add("Irmão", "(+14) 1 2345-6789");

        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"| -> {item.Key} > {item.Value}");
        }

        // 2. Pesquisar um contato pelo nome.
        // Console.WriteLine("Contato: ");
        // var contato = Console.ReadLine();
        // foreach (var item in dicionario)
        // {
        //     if (item == contato)
        //     {
        //         Console.WriteLine($"o nuémero de {contato} é -> {item.Value}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Contato desconhecido ;(");
        //     }
        // }

        // 3. Alterar um elemento do dicionario
        var At = dicionario["Pai"] = "(+14) 9 8765-4321";
        Console.WriteLine();
        Console.WriteLine("====== LISTA ATULIZADA ======");
        foreach (var item in dicionario)
        {
            
            Console.WriteLine($"| -> {item.Key} > {item.Value}");
        }

        //4. Remover um contato.
        dicionario.Remove("Pai");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"| -> {item.Key} > {item.Value}");
        }
    }
}