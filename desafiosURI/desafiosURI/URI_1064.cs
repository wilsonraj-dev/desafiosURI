using System;
using System.Globalization;

namespace desafiosURI
{
    class URI_1064
    {
        /* Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, 
          deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

          Entrada
          A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.

          Saída
          O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados. */

        static void Main(string[] args)
        {
            double somaDosNumeros = 0;
            int contadorDePositivos = 0;
            double media = 0;
            for (int i = 1; i <= 6; i++)
            {
                double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (numero >= 0)
                {
                    somaDosNumeros += numero;
                    contadorDePositivos++;
                }
            }
            Console.WriteLine(contadorDePositivos + " valores positivos");
            media = somaDosNumeros / contadorDePositivos;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
