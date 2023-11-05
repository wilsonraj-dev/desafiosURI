//https://www.beecrowd.com.br/judge/pt/problems/view/1259
using System;
using System.Collections.Generic;

namespace desafiosURI.Codigos
{
    internal class _1259
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }

            pares.Sort();
            impares.Sort((a, b) => b.CompareTo(a));

            foreach (int numeroPar in pares)
            {
                Console.WriteLine(numeroPar);
            }

            foreach (int numeroImpar in impares)
            {
                Console.WriteLine(numeroImpar);
            }
        }
    }
}
