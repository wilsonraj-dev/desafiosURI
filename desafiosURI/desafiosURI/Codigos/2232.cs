//https://www.beecrowd.com.br/judge/pt/problems/view/2232
using System;

namespace desafiosURI.Codigos
{
    class _2232
    {
        static void Main(string[] args)
        {
            int t, n;
            t = int.Parse(Console.ReadLine());

            while (t-- != 0)
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(2, n) - 1);
            }
        }
    }
}
