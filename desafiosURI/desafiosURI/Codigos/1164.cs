//https://www.beecrowd.com.br/judge/pt/problems/view/1164
using System;

namespace desafiosURI.Codigos
{
    class _1164
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int soma = 0;

                for (int j = 1; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        soma += j;
                    }
                }

                if (soma == x)
                    Console.WriteLine($"{x} eh perfeito");
                else
                    Console.WriteLine($"{x} nao eh perfeito");
            }
        }
    }
}
