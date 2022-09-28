//https://www.beecrowd.com.br/judge/pt/problems/view/1165
using System;

namespace desafiosURI
{
    class URI_1165
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int contador;
            for (int i = 0; i < X; i++)
            {
                contador = 0;
                int Y = int.Parse(Console.ReadLine());
                for (int j = 2; j < Y; j++)
                {
                    if (Y % j == 0)
                        contador++;
                }
                if (contador == 0)
                    Console.WriteLine(Y + " eh primo");
                else
                    Console.WriteLine(Y + " nao eh primo");
            }
        }
    }
}