//https://www.beecrowd.com.br/judge/pt/problems/view/1117
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class URI_1117
    {
        static void Main(string[] args)
        {
            int contador = 1;
            double somaNotas = 0;
            double media = 0;
            while (contador <= 2)
            {
                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (notas >= 0 && notas <= 10)
                {
                    somaNotas += notas;
                    contador++;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            media = somaNotas / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}