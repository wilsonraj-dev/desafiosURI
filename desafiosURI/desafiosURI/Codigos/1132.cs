//https://www.beecrowd.com.br/judge/pt/problems/view/1132
using System;

namespace desafiosURI
{
    class URI_1132
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int soma = 0;

            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (i % 13 != 0)
                        soma += i;
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                        soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}