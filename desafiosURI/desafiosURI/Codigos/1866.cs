//https://www.beecrowd.com.br/judge/pt/problems/view/1866
using System;

namespace desafiosURI.Codigos
{
    class _1866
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int x = 0;

                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                        x++;
                    else
                        x--;
                }
                Console.WriteLine(x);
            }
        }
    }
}
