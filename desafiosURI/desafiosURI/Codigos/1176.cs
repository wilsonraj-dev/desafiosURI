//https://www.beecrowd.com.br/judge/pt/problems/view/1176
using System;

namespace desafiosURI.Codigos
{
    class _1176
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());

                long anterior = 0, atual = 1, proximo;
                for (int j = 0; j < n; j++)
                {
                    proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                }
                Console.WriteLine($"Fib({n}) = {anterior}");
            }
        }
    }
}
