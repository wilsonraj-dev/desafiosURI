//https://www.beecrowd.com.br/judge/pt/problems/view/1180
using System;

namespace desafiosURI
{
    class _1180
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] x = new int[n];
            int menor = 1000;
            int posicao = 0;
            string[] aux = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(aux[i]);

                if (menor >= x[i])
                {
                    menor = x[i];
                    posicao = i;
                }
            }

            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Posicao: {posicao}");
        }
    }
}
