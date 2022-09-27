using System;

namespace desafiosURI.Codigos
{
    class URI_1101
    {
        static void Main(string[] args)
        {
            /* Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). 
            Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

            Entrada
            O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

            Saída
            Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo. */

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
