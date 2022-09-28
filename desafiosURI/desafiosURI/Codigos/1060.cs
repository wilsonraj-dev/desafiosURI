//https://www.beecrowd.com.br/judge/pt/problems/view/1060
using System;

namespace desafiosURI
{
    class URI_1060
    {
        static void Main(string[] args)
        {
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