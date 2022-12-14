//https://www.beecrowd.com.br/judge/pt/problems/view/1933
using System;

namespace desafiosURI.Codigos
{
    class _1933
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            int n1 = int.Parse(v[0]);
            int n2 = int.Parse(v[1]);

            if (n1 == n2)
                Console.WriteLine(n1);
            else if (n1 > n2)
                Console.WriteLine(n1);
            else if (n2 > n1)
                Console.WriteLine(n2);
        }
    }
}
