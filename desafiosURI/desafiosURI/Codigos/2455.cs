//https://www.beecrowd.com.br/judge/pt/problems/view/2455
using System;

namespace desafiosURI.Codigos
{
    class _2455
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int p1 = int.Parse(valores[0]);
            int c1 = int.Parse(valores[1]);
            int p2 = int.Parse(valores[2]);
            int c2 = int.Parse(valores[3]);

            if ((p1 * c1) == (p2 * c2))
                Console.WriteLine("0");
            else if ((p1 * c1) < (p2 * c2))
                Console.WriteLine("1");
            else
                Console.WriteLine("-1");
        }
    }
}
