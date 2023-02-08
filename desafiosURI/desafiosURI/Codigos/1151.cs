//https://www.beecrowd.com.br/judge/pt/problems/view/1151
using System;

namespace desafiosURI.Codigos
{
    class _1151
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.WriteLine(string.Join(" ", fib));
        }
    }
}
