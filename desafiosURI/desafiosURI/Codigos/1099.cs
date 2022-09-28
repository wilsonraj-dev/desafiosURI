//https://www.beecrowd.com.br/judge/pt/problems/view/1099
using System;

namespace desafiosURI.Codigos
{
    class URI_1099
    {
        static void Main(string[] args)
        {
            int numeroCasos = int.Parse(Console.ReadLine());
            int soma;

            for (int i = 0; i < numeroCasos; i++)
            {
                soma = 0;
                string[] XeY = Console.ReadLine().Split(' ');
                int X = int.Parse(XeY[0]);
                int Y = int.Parse(XeY[1]);

                if (Y > X)
                {
                    for (int j = X + 1; j < Y; j++)
                    {
                        if (j % 2 != 0)
                            soma += j;
                    }
                }
                else
                {
                    for (int j = Y + 1; j < X; j++)
                    {
                        if (j % 2 != 0)
                            soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}