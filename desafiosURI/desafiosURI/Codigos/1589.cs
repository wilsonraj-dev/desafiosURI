//https://www.beecrowd.com.br/judge/pt/problems/view/1589
using System;

namespace desafiosURI.Codigos
{
    class _1589
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                int r1 = int.Parse(v[0]);
                int r2 = int.Parse(v[1]);
                int menorRaio = r1 + r2;

                Console.WriteLine(menorRaio);
            }
        }
    }
}
