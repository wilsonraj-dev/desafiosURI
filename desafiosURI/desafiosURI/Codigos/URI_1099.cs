using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI.Codigos
{
    class URI_1099
    {
        /* Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

        Entrada
        A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

        Saída
        Imprima a soma de todos valores ímpares entre X e Y. */

        static void Main(string[] args)
        {
            int numeroCasos = int.Parse(Console.ReadLine());
            int soma;

            for (int i = 0; i < numeroCasos; i++)
            {
                soma = 0;
                string[] XeY = Console.ReadLine().Split(' ');
                int X = int.Parse(XeY[0]);
                int Y = int.Parse(XeY[1]);

                if (Y > X)
                {
                    for (int j = X + 1; j < Y; j++)
                    {
                        if (j % 2 != 0)
                            soma += j;
                    }
                }
                else
                {
                    for (int j = Y + 1; j < X; j++)
                    {
                        if (j % 2 != 0)
                            soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
