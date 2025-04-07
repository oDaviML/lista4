namespace Ex7;

class Program
{
    static void Main(string[] args)
    {
        char op;

        do
        {
            double salario = double.Parse(Console.ReadLine());
            double taxa = 0;

            // Faixa 1
            taxa += 1412 * 0.075;
            
            
            // Faixa 2
            if (salario <= 2666.68 && salario > 1412.01)
            {
                taxa += (salario - 1412.01) * 0.09;
            }
            else if (salario > 2666.68)
            {
                taxa += (2666.68 - 1412.01) * 0.09;
            }

            // Faixa 3
            if (salario <= 4000.03 && salario > 2666.69)
            {
                taxa += (salario - 2666.69) * 0.12;
            }
            else if (salario > 4000.03)
            {
                taxa += (4000.03 - 2666.69) * 0.12;
            }

            // Faixa 4
            if (salario <= 7786.02 && salario > 4000.04)
            {
                taxa += (salario - 4000.04) * 0.14;
            }
            else if (salario > 7786.02)
            {
                taxa += (7786.02 - 4000.04) * 0.14;
            }

            Console.WriteLine($"Total taxas: {taxa:F2}");

            Console.WriteLine("Deseja informar mais um salario (S: sim, N: não)");
            op = char.Parse(Console.ReadLine().ToUpper());
            
        } while (op == 'S');
        
    }
}