//https://www.beecrowd.com.br/judge/pt/problems/view/1101
using System;

namespace desafiosURI.Codigos
{
    class URI_1101
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int M = int.Parse(numeros[0]);
            int N = int.Parse(numeros[1]);
            int aux = 0, soma = 0;

            while (M > 0 && N > 0)
            {
                if (N < M)
                {
                    aux = M;
                    M = N;
                    N = aux;
                }

                for (int i = M; i <= N; i++)
                {
                    soma += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);
                soma = 0;
                numeros = Console.ReadLine().Split(' ');
                M = int.Parse(numeros[0]);
                N = int.Parse(numeros[1]);
            }
        }
    }
}