﻿//https://www.beecrowd.com.br/judge/pt/problems/view/1157
using System;

namespace desafiosURI.Codigos
{
    class _1157
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
