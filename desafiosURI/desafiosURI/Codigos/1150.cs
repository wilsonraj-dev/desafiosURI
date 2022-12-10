//https://www.beecrowd.com.br/judge/pt/problems/view/1150
using System;

namespace desafiosURI.Codigos
{
    class _1150
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int soma = 0;
            int contador = 0;

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }
            while (soma < z)
            {
                soma += x;
                contador++;
                x++;
            }
            Console.WriteLine(contador);
        }
    }
}
