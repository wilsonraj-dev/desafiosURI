//https://www.beecrowd.com.br/judge/pt/problems/view/2140
using System;

namespace desafiosURI.Codigos
{
    internal class _2140
    {
        static void Main(string[] args)
        {
            int[] notas = new int[] { 2, 5, 10, 20, 50, 100 };

            while (true)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(valores[0]);
                int M = Convert.ToInt32(valores[1]);
                bool possivel = false;

                if (N == 0 && M == 0) break;

                int troco = M - N;

                for (int i = 0; i < notas.Length; i++)
                {
                    for (int j = 0; j < notas.Length; j++)
                    {
                        if (troco - notas[j] == notas[i]) possivel = true;
                    }
                }

                if (possivel) Console.WriteLine("possible");
                else Console.WriteLine("impossible");
            }
        }
    }
}
