namespace Ex1;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 25; i++)
        {   
            Console.WriteLine($"Informe o valor do vale alimentacao do {i + 1}º");
            double valorAlimentacao = double.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o valor do vale transporte do {i + 1}º");
            double valorTransporte = double.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o produzido do {i + 1}º");
            double metrosProduzidos = double.Parse(Console.ReadLine());

            double total = 0;
            
            total += valorAlimentacao + (valorTransporte * 2);

            if (metrosProduzidos < 10)
            {
                total += metrosProduzidos * 10;
            }
            else if (metrosProduzidos <= 20)
            {
                total += metrosProduzidos * 11.50;
            }
            else
            {
                total += metrosProduzidos * 13;
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}