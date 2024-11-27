//https://judge.beecrowd.com/pt/problems/view/1973
using System;

namespace desafiosURI.Codigos
{
    internal class _1973
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] estrela = new int[N];
            int[] carneiro = new int[N];
            string[] valoresArray = Console.ReadLine().Split(' ');
            long totalEstrela = 0;
            long totalCarneiro = 0;

            for (int i = 0; i < valoresArray.Length; i++)
            {
                carneiro[i] = int.Parse(valoresArray[i]);
                estrela[i] = 0;
            }

            int j = 0;

            while (true)
            {
                if (j == 0 && carneiro[j] % 2 == 0)
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    break;
                }
                else if (j == (N - 1) && carneiro[j] % 2 == 1)
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    break;
                }
                else if (carneiro[j] % 2 == 1)
                {
                    if (carneiro[j] > 0) carneiro[j]--;
                    estrela[j] = 1;
                    j++;
                }
                else if (carneiro[j] % 2 == 0)
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    j--;
                }
            }

            for (int i = 0; i < N; i++)
            {
                totalCarneiro += carneiro[i];
                totalEstrela += estrela[i];
            }

            Console.WriteLine(totalEstrela + " " + totalCarneiro);
        }
    }
}
