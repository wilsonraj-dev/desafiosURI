//https://www.beecrowd.com.br/judge/pt/problems/view/2454
using System;

namespace desafiosURI.Codigos
{
    class _2454
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int p = int.Parse(valores[0]);
            int r = int.Parse(valores[1]);

            if (p == 0)
                Console.WriteLine("C");
            else if (p == 1 && r == 1)
                Console.WriteLine("A");
            else if (p == 1 && r == 0)
                Console.WriteLine("B");
        }
    }
}
