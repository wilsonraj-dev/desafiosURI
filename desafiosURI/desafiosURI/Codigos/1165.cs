﻿using System;

namespace desafiosURI
{
    class URI_1165
    {
        static void Main(string[] args)
        {
            /* Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo. Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.

            Entrada
            A entrada contém vários casos de teste. A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100), indicando o número de casos de teste da entrada. Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 107), que pode ser ou não, um número primo.

            Saída
            Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”, de acordo com a especificação fornecida. */

            int X = int.Parse(Console.ReadLine());
            int contador;
            for (int i = 0; i < X; i++)
            {
                contador = 0;
                int Y = int.Parse(Console.ReadLine());
                for (int j = 2; j < Y; j++)
                {
                    if (Y % j == 0)
                        contador++;
                }
                if (contador == 0)
                    Console.WriteLine(Y + " eh primo");
                else
                    Console.WriteLine(Y + " nao eh primo");
            }
        }
    }
}
