//https://www.beecrowd.com.br/judge/pt/problems/view/2344
using System;

namespace desafiosURI.Codigos
{
    class _2344
    {
        static void Main(string[] args)
        {

            int nota = int.Parse(Console.ReadLine());

            if (nota >= 86 && nota <= 100)
                Console.WriteLine("A");
            else if (nota >= 61 && nota <= 85)
                Console.WriteLine("B");
            else if (nota >= 36 && nota <= 60)
                Console.WriteLine("C");
            else if (nota >= 1 && nota <= 35)
                Console.WriteLine("D");
            else if (nota == 0)
                Console.WriteLine("E");
        }

    }
}
