using System;

namespace desafiosURI
{
    class URI_1153
    {
        static void Main(string[] args)
        {
            /* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

            Entrada
            A entrada contém um valor inteiro N (0 < N < 13).

            Saída
            A saída contém um valor inteiro, correspondente ao fatorial de N. */

            int N, fat = 1;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                fat *= i;
            }
            Console.WriteLine(fat);
            Console.ReadLine();
        }
    }
}
