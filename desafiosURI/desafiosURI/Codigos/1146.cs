//https://www.beecrowd.com.br/judge/pt/problems/view/1146
using System;

namespace desafiosURI.Codigos
{
    class _1146
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                        Console.WriteLine($"{i}");
                    else
                        Console.Write($"{i} ");
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
