namespace Ex5;

class Program
{
    static void Main(string[] args)
    {
        char op;
        int qntVoto1 = 0, qntVoto2 = 0, qntVoto3 = 0, totalVotoBranco = 0, qntVotoNulo = 0, candidatoMaisVotado = 0;
        
        do
        {
            Console.WriteLine("Informe seu voto:");
            int voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case 1:
                    qntVoto1++;
                    break;
                case 2:
                    qntVoto2++;
                    break;
                case 3:
                    qntVoto3++;
                    break;
                case 4:
                    totalVotoBranco++;
                    break;
                default:
                    qntVotoNulo++;
                    break;
            }
            
            Console.WriteLine("Deseja informar mais um voto (S: sim, N: não)");
            op = char.Parse(Console.ReadLine().ToUpper());
        } while (op == 'S');

        Console.WriteLine($"Votos candidato 1: {qntVoto1}");
        Console.WriteLine($"Votos candidato 2: {qntVoto2}");
        Console.WriteLine($"Votos candidato 3: {qntVoto3}");

        if (qntVoto1 > qntVoto2 && qntVoto1 > qntVoto3)
        {
            candidatoMaisVotado = 1;
        }else if (qntVoto2 > qntVoto1 && qntVoto2 > qntVoto3)
        {
            candidatoMaisVotado = 2;
        }
        else if (qntVoto3 > qntVoto1 && qntVoto3 > qntVoto2)
        {
            candidatoMaisVotado = 3;
        }

        Console.WriteLine(candidatoMaisVotado == 0 ? $"Resultado votos: Empate": $"Candidato mais votado {candidatoMaisVotado}");
        Console.WriteLine($"Votos em branco: {totalVotoBranco}");
        Console.WriteLine($"Votos nulos: {qntVotoNulo}");
    }
}