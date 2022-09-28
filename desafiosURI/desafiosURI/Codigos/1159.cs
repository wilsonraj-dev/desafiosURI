//https://www.beecrowd.com.br/judge/pt/problems/view/1159
using System;

namespace desafiosURI.Codigos
{
    class URI_1159
    {
        static void Main(string[] args)
        {
            int X, Z, somaNumeros = 0;
            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {

                for (Z = 0; Z < 5; X++)
                {
                    if (X % 2 == 0)
                    {
                        somaNumeros += X;
                        Z++;
                    }
                }
                Console.WriteLine(somaNumeros);
                somaNumeros = 0;
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}