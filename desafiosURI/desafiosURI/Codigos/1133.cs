//https://www.beecrowd.com.br/judge/pt/problems/view/1133
using System;

namespace desafiosURI.Codigos
{
    class URI_1133
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int aux = 0;

            if (Y < X)
            {
                aux = X;
                X = Y;
                Y = aux;
            }

            for (int i = X + 1; i < Y; i++)
            {
                if (i % 5 == 3 || i % 5 == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}