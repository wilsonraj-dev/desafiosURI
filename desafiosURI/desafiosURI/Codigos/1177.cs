//https://www.beecrowd.com.br/judge/pt/problems/view/1177
using System;

namespace desafiosURI.Codigos
{
    class _1177
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] n = new int[1000];
            int posicao = 0;

            while (posicao < 999)
            {
                for (int j = 0; j < t; j++)
                {
                    if (posicao > 999)
                        break;

                    n[posicao] = j;
                    posicao++;
                }
            }

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("N[" + i + "] = " + n[i]);
            }
        }
    }
}
