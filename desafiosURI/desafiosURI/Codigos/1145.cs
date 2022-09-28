using System;

namespace desafiosURI.Codigos
{
    class _1145
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

            Entrada
            O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

            Saída
            Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme exemplo abaixo. 
            Não deve haver espaço em branco após o último valor da linha. */

            string[] vet = Console.ReadLine().Split(' ');
            int X, Y, J = 0;
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);
            for (int i = 1; i <= Y; i++)
            {
                J++;
                Console.Write(i);
                if (J == X || i == Y)
                {
                    Console.Write("\n");
                    J = 0;
                }
                else
                    Console.Write(" ");
            }
        }
    }
}
