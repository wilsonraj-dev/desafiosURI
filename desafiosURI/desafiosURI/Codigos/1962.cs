//https://www.beecrowd.com.br/judge/pt/problems/view/1962
using System;

namespace desafiosURI.Codigos
{
    internal class _1962
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int T = int.Parse(Console.ReadLine());

                if (T >= 2015)
                {
                    Console.WriteLine((T - 2015) + 1 + " A.C.");
                }
                else
                {
                    Console.WriteLine(2015 - T + " D.C.");
                }
            }
        }
    }
}
