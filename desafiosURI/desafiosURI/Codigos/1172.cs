//https://www.beecrowd.com.br/judge/pt/problems/view/1172
using System;

namespace desafiosURI
{
    class URI_1172
    {
        static void Main(string[] args)
        {
            int[] vetorX = new int[10];

            for (int i = 0; i < vetorX.Length; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                vetorX[i] = valores;

                if (vetorX[i] == 0 || vetorX[i] < 0)
                    vetorX[i] = 1;

                Console.WriteLine($"X[{i}] = {vetorX[i]}");
            }
        }
    }
}