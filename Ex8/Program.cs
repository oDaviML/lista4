namespace Ex8;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int contador = 0;
        int impar = 1;

        do
        {
            n -= impar;
            impar += 2;
            contador++;
        } while (n > 0);

        if (n == 0)
        {
            Console.WriteLine(contador);
        }
        else
        {
            Console.WriteLine("Raiz invalida");
        }
        
    }
}