//https://www.beecrowd.com.br/judge/pt/problems/view/3342
using System;

namespace desafiosURI.Codigos
{
    class _3342
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int brancas;
            int pretas;
            int total = n * n;

            pretas = total / 2;
            brancas = total - pretas;
            Console.WriteLine($"{brancas} casas brancas e {pretas} casas pretas");
        }
    }
}
