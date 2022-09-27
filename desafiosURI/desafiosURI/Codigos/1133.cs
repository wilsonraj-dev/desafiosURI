using System;

namespace desafiosURI.Codigos
{
    class URI_1133
    {
        /* Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.

        Entrada
        O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.

        Saída
        Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente. */

        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int aux = 0;

            if (Y < X)
            {
                aux = X;
                X = Y;
                Y = aux;
            }

            for (int i = X + 1; i < Y; i++)
            {
                if (i % 5 == 3 || i % 5 == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
