namespace Ex2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double soma = 1;

        for (int i = 1; i <= n; i++)
        {
            int fatorial = i;
            for (int j = i - 1; j >= 1; j--)
            {
                fatorial *= j;
            }

            soma += (double) 1 / fatorial;
        }
        Console.WriteLine($"{soma:F2}");
    }
}