internal class Program
{
    public class carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            if (Velocidade >= 10)
            {
                Velocidade -= 10;
            }
            else
            {
                Velocidade = 0;
            }

        }
        private static void Main(string[] args)
        {
            carro Carro1 = new carro();
            carro Carro2 = new carro();
            carro Carro3 = new carro();

            // Marca
            Carro1.Marca = "FIAT";
            Carro2.Marca = "Hyundai";
            Carro3.Marca = "Nissan";

            // Modelo
            Carro1.Modelo = "FIAT Toro";
            Carro2.Modelo = "Hyundai Creta";
            Carro3.Modelo = "Nissan GT-R";

            // Velocidade
            Carro1.Velocidade = 150;
            Carro2.Velocidade = 200;
            Carro3.Velocidade = 330;

            Console.WriteLine($"\n| Modelo: {Carro1.Modelo} \n| Marca: {Carro1.Marca} \n| Velocidade: {Carro1.Velocidade}");
            Console.WriteLine($"\n| Modelo: {Carro2.Modelo} \n| Marca: {Carro2.Marca} \n| Velocidade: {Carro2.Velocidade}");
            Console.WriteLine($"\n| Modelo: {Carro3.Modelo} \n| Marca: {Carro3.Marca} \n| Velocidade: {Carro3.Velocidade}");


            // Acelerando o carro 1
            Console.WriteLine($"\n=== ACELERANDO O {Carro1.Modelo} ===");

            Carro1.Acelerar();
            Console.WriteLine($"Velocidade: {Carro1.Velocidade} km/h");

            Carro1.Acelerar();
            Console.WriteLine($"Velocidade: {Carro1.Velocidade} km/h");


            // Desacelerando o carro 2
            Console.WriteLine($"\n=== DESACELERANDO O {Carro2.Modelo} ===");

            Carro2.Desacelerar();
            Console.WriteLine($"Velocidade: {Carro2.Velocidade} km/h");

            Carro2.Desacelerar();
            Console.WriteLine($"Velocidade: {Carro2.Velocidade} km/h");


            // Desacelerando o carro 3
            Console.WriteLine($"\n=== DESACELERANDO O {Carro3.Modelo} ===");

            Carro3.Desacelerar();
            Console.WriteLine($"Velocidade: {Carro3.Velocidade} km/h");

            Carro3.Desacelerar();
            Console.WriteLine($"Velocidade: {Carro3.Velocidade} km/h");
        }
    }
}
