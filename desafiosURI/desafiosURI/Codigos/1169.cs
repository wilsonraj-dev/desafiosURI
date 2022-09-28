//https://www.beecrowd.com.br/judge/pt/problems/view/1169
using System;

namespace desafiosURI.Codigos
{
    class _1169
    {
        static void Main(string[] args)
        {
            ulong resultado;
            int j, casas, qtdTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdTeste; i++)
            {
                casas = int.Parse(Console.ReadLine());
                j = 0;
                resultado = 0;

                do
                {
                    resultado += (ulong)Math.Pow(2, j);
                    j++;
                } while (j < casas);

                resultado /= 12000;
                Console.WriteLine($"{resultado} kg");
            }
        }
    }
}