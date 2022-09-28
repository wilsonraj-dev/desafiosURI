//https://www.beecrowd.com.br/judge/pt/problems/view/1155
using System;

namespace desafiosURI.Codigos
{
    class _1155
    {
        static void Main(string[] args)
        {
            double S = 1;
            for (int i = 2; i <= 100; i++)
            {
                S = S + 1.00 / i;
            }
            var x = Math.Round(S, 2);
            Console.WriteLine(x.ToString("F2"));
        }
    }
}
