//https://www.beecrowd.com.br/judge/pt/problems/view/2791
using System;

namespace desafiosURI.Codigos
{
    class _2791
    {
        static void Main(string[] args)
        {

            string[] v = Console.ReadLine().Split(' ');

            int c1 = int.Parse(v[0]);
            int c2 = int.Parse(v[1]);
            int c3 = int.Parse(v[2]);
            int c4 = int.Parse(v[3]);

            if (c1 == 1)
                Console.WriteLine(1);
            else if (c2 == 1)
                Console.WriteLine(2);
            if (c3 == 1)
                Console.WriteLine(3);
            if (c4 == 1)
                Console.WriteLine(4);
        }
    }
}
