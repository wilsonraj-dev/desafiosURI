//https://judge.beecrowd.com/pt/problems/view/2028
using System;
using System.Collections.Generic;

namespace desafiosURI.Codigos
{
    internal class _2028
    {
        static void Main(string[] args)
        {
            int caso = 1;
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                int N = int.Parse(entrada);

                var (quantidade, sequencia) = GerarSequencia(N);

                if (sequencia.Count == 1)
                {
                    Console.WriteLine($"Caso {caso}: {quantidade} numero");
                }
                else
                {
                    Console.WriteLine($"Caso {caso}: {quantidade} numeros");
                }

                Console.WriteLine(string.Join(" ", sequencia));
                Console.WriteLine();

                caso++;
            }
        }

        static (int, List<int>) GerarSequencia(int N)
        {
            List<int> sequencia = new List<int>();

            sequencia.Add(0);
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sequencia.Add(i);
                }
            }

            return (sequencia.Count, sequencia);
        }
    }
}
