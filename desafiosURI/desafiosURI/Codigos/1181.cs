//https://www.beecrowd.com.br/judge/pt/problems/view/1181
using System;

namespace desafiosURI.Codigos
{
    class _1181
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            char T = char.Parse(Console.ReadLine());

            double[,] M = new double[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    M[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double sum = 0.0;
            for (int j = 0; j < 12; j++)
            {
                sum += M[L, j];
            }

            if (T == 'M')
            {
                sum /= 12.0;
            }

            Console.WriteLine(sum.ToString("F1"));
        }
    }
}
