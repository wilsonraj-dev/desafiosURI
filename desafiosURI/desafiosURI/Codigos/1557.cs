//https://judge.beecrowd.com/pt/problems/view/1557
using System;

namespace desafiosURI.Codigos
{
    internal class _1557
    {
        static void Main()
        {
            int N;

            while ((N = int.Parse(Console.ReadLine())) != 0)
            {
                int[,] matriz = new int[N, N];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matriz[i, j] = (int)Math.Pow(2, i + j);
                    }
                }

                int maiorNumero = matriz[N - 1, N - 1];
                int T = maiorNumero.ToString().Length;

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(matriz[i, j].ToString().PadLeft(T));

                        if (j < N - 1)
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
