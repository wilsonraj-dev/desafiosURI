//https://www.beecrowd.com.br/judge/pt/problems/view/1241
using System;

namespace desafiosURI.Codigos
{
    internal class _1241
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                string A = vet[0];
                string B = vet[1];

                if (A.Length < B.Length)
                {
                    Console.WriteLine("nao encaixa");
                    continue;
                }

                string ultimosDigitos = A.Substring(A.Length - B.Length, B.Length);
                if (ultimosDigitos == B) Console.WriteLine("encaixa");
                else Console.WriteLine("nao encaixa");
            }
        }
    }
}
