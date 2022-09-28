//https://www.beecrowd.com.br/judge/pt/problems/view/1142
using System;

namespace desafiosURI
{
    class URI_1142
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int contador = 1;
            int numeroSequencia = 1;

            while (contador <= N)
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (numeroSequencia % 4 != 0)
                    {
                        Console.Write($"{numeroSequencia} ");
                        numeroSequencia++;
                    }
                    else if (numeroSequencia % 4 == 0)
                    {
                        Console.Write("PUM\n");
                        numeroSequencia++;
                    }
                }
                contador++;
            }
        }
    }
}