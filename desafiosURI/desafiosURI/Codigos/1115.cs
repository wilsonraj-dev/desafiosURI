//https://www.beecrowd.com.br/judge/pt/problems/view/1115
using System;

namespace desafiosURI.Codigos
{
    class _1115
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');
            int n1 = int.Parse(entradas[0]);
            int n2 = int.Parse(entradas[1]);

            while (n1 != 0 || n2 != 0)
            {
                if (n1 > 0 && n2 > 0)
                    Console.WriteLine("primeiro");
                else if (n1 > 0 && n2 < 0)
                    Console.WriteLine("quarto");
                else if (n1 < 0 && n2 < 0)
                    Console.WriteLine("terceiro");
                else if (n1 < 0 && n2 > 0)
                    Console.WriteLine("segundo");

                entradas = Console.ReadLine().Split(' ');
                n1 = int.Parse(entradas[0]);
                n2 = int.Parse(entradas[1]);
            }
        }
    }
}
