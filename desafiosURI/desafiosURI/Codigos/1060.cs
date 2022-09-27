using System;

namespace desafiosURI
{
    class URI_1060
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos 
            (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

            Entrada
            Seis valores, negativos e/ou positivos.

            Saída
            Imprima uma mensagem dizendo quantos valores positivos foram lidos. */

            double x, soma = 0, media = 0, p = 0;
            for (int i = 1; i <= 6; i++)
            {
                x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    p++;
                    soma += x;
                    media = soma / p;
                }
            }
            Console.WriteLine(p + " valores positivos");
            Console.WriteLine(media);
        }
    }
}
