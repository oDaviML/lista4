namespace Ex3;

class Program
{
    static void Main(string[] args)
    {
        double maiorConsumo = 0, menorConsumo = 0, consumoMedio = 0, totalConsumo = 0;
        
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Informe o preco do kWh");
            double precokWh = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de kWh consumido");
            double consumo = double.Parse(Console.ReadLine());
            
            double totalPagar = precokWh + consumo;
            totalConsumo += consumo;

            if (consumo > maiorConsumo) 
            {
                maiorConsumo = consumo;
            }

            if (consumo < menorConsumo || menorConsumo == 0)
            {
                menorConsumo = consumo;
            }

            Console.WriteLine($"Total a pagar: {totalPagar}");
        }
        
        consumoMedio = totalConsumo / 50;
        Console.WriteLine($"Maior consumo verificado: {maiorConsumo}");
        Console.WriteLine($"Menor consumo verificado: {menorConsumo}");
        Console.WriteLine($"Consumo medio: {consumoMedio}");
    }
}