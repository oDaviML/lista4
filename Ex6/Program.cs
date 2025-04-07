namespace Ex6;

class Program
{
    static void Main(string[] args)
    {

        int op;
        do
        {
            Console.WriteLine("1. Converter de Celsius para Fahrenheit\n" +
                              "2. Converter de Celsius para Kelvin\n" +
                              "3. Converter de Fahrenheit para Celsius\n" +
                              "4. Converter de Fahrenheit para Kelvin\n" +
                              "5. Converter de Kelvin para Celsius\n" +
                              "6. Converter de Kelvin para Fahrenheit\n" +
                              "7. Sair");
            op = int.Parse(Console.ReadLine());

            double temperatura;
            switch (op)
            {
                case 1:
                     
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{((temperatura / 1.8) + 32):F2}");
                    break;
                case 2:
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(temperatura + 273.15):F2}");
                    break;
                case 3:
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{((temperatura - 32) / 1.8):F2}");
                    break;
                case 4:
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{((temperatura - 32) / 1.8 + 273.15):F2}");
                    break;
                case 5:
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(temperatura - 273.15):F2}");
                    break;
                case 6:
                    temperatura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{((temperatura - 273.15) * 1.8 + 32):F2}");
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        } while (op != 7);
    }
}