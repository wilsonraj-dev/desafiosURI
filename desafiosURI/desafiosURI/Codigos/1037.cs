//https://www.beecrowd.com.br/judge/pt/problems/view/1037
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class URI_1037
    {
        static void Main(string[] args)
        {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.00 && numero <= 25.00)
                Console.WriteLine("Intervalo [0, 25]");
            else if (numero >= 25.01 && numero <= 50.00)
                Console.WriteLine("Intervalo [25, 50]");
            else if (numero >= 50.01 && numero <= 100.00)
                Console.WriteLine("Intervalo (75, 100]");
            else
                Console.WriteLine("Fora de intervalo");

        }
    }
}