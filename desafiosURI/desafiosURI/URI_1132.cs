﻿using System;

namespace desafiosURI
{
    class URI_1132
    {
        static void Main(string[] args)
        {
            /* Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

            Entrada
            O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.

            Saída
            Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, inclusive ambos se for o caso. */

            int x, y = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int soma = 0;

            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                        soma += i;
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                        soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
