//https://www.beecrowd.com.br/judge/pt/problems/view/2167
using System;

namespace desafiosURI.Codigos
{
    internal class _2167
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] medidas = new int[n];
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                medidas[i] = int.Parse(valores[i]);
            }

            int indiceQueda = EncontrarIndicePrimeiraQueda(medidas);

            Console.WriteLine(indiceQueda);
        }

        static int EncontrarIndicePrimeiraQueda(int[] medidas)
        {
            for (int i = 1; i < medidas.Length; i++)
            {
                if (medidas[i] < medidas[i - 1])
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
