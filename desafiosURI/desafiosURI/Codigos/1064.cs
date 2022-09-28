//https://www.beecrowd.com.br/judge/pt/problems/view/1064
using System;
using System.Globalization;

namespace desafiosURI
{
    class URI_1064
    {
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