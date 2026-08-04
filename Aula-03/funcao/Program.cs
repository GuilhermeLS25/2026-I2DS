internal class Program
{
    private static void Main(string[] args)
    {
        Ola("Cristiano");
        Ola("Maria");
        Ola("João");

        Console.WriteLine("A soma de 2  mais o 3 é igual a: " + Calcular(2, 3, "+"));
        Console.WriteLine("A subtração de 2  mais o 3 é igual a: " + Calcular(2, 3, "-"));
        Console.WriteLine("A multiplicação de 2  mais o 3 é igual a: " + Calcular(2, 3, "*"));
        Console.WriteLine("A divisão de 2  mais o 3 é igual a: " + Calcular(2, 3, "/"));
    }

    /* 
    public static void Ola()
    {
        Console.WriteLine("Olá, Seja Bem-Vindo!");
    }
    */

    // Função com parametro nome e sem retorno
    public static void Ola(string nome)
    {
        Console.WriteLine("Olá " + nome + ", Seja Bem-Vindo(a)!");
    }

    public static double Calcular(double num1, double num2, string operador)
    {
        double resultado = 0;
        
        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("operador informado não é válido.");
                break;
        }
        
        return resultado;
    }
}