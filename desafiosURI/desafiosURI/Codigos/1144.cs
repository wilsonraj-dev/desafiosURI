//https://www.beecrowd.com.br/judge/pt/problems/view/1144
using System;

namespace desafiosURI.Codigos
{
    class URI_1144
    {
        static void Main(string[] args)
        {
            double N = int.Parse(Console.ReadLine());
            double quadrado = 1;
            double multiplicador = 0;

            for (double i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} { quadrado = Math.Pow(i, 2)} {multiplicador = i * quadrado}");
                quadrado++;
                multiplicador++;
                Console.WriteLine($"{i} {quadrado} {multiplicador}");
            }
        }
    }
}