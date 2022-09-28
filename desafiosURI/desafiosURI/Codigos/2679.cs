//https://www.beecrowd.com.br/judge/pt/problems/view/2679
using System;

namespace desafiosURI.Codigos
{
    class _2679
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
                x += 2;
            else
                x += 1;

            Console.WriteLine(x);
        }
    }
}
