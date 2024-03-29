﻿//https://www.beecrowd.com.br/judge/pt/problems/view/1160
using System;

namespace desafiosURI.Codigos
{
    class _1160
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int pa, pb;
            int anos;

            double[] arrayList = new double[4];
            double cpa, cpb;

            for (int i = 0; i < t; i++)
            {
                anos = 0;

                string[] valores = Console.ReadLine().Split();

                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb && anos < 101)
                {
                    pa += (int)((pa * cpa) / 100);
                    pb += (int)((pb * cpb) / 100);

                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }
    }
}