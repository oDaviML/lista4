namespace Ex4;

class Program
{
    static void Main(string[] args)
    {
        double maiorTemperatura = 0, diaMaiorTemp = 0, menorTemperatura = 0, diaMenorTemp = 0;
        
        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("Informe a temperatura media");
            double temperatura = double.Parse(Console.ReadLine());
            
            if (temperatura > maiorTemperatura)
            {
                maiorTemperatura = temperatura;
                diaMaiorTemp = i + 1;
            }

            if (temperatura < menorTemperatura || menorTemperatura == 0)
            {
                menorTemperatura = temperatura;
                diaMenorTemp = i + 1;
            }
        }

        Console.WriteLine($"Maior temperatura: {maiorTemperatura}, dia temperatura: {diaMaiorTemp}");
        Console.WriteLine($"Menor temperatura: {menorTemperatura}, dia temperatura: {diaMenorTemp}");
    }
}