//https://www.beecrowd.com.br/judge/pt/problems/view/1865
using System;

namespace desafiosURI.Codigos
{
    class _1865
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                string nome = dados[0];

                if (nome.ToLower().Equals("thor"))
                    Console.WriteLine("Y");
                else
                    Console.WriteLine("N");
            }
        }
    }
}
