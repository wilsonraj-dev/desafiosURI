//https://www.beecrowd.com.br/judge/pt/problems/view/1959
using System;

namespace desafiosURI.Codigos
{
    class _1959
    {
        static void Main(string[] args)
        {

            string[] v = Console.ReadLine().Split(' ');
            long N = long.Parse(v[0]);
            long L = long.Parse(v[1]);

            long P = N * L;
            Console.WriteLine(P);
        }
    }
}
