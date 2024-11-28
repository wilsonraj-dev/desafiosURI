//https://judge.beecrowd.com/pt/problems/view/3204
using System;
using System.Collections.Generic;

namespace desafiosURI.Codigos
{
    internal class _3204
    {
        static int[,] directions = new int[,] {
        { 1, 0 },  // Direita
        { -1, 0 }, // Esquerda
        { 0, 1 },  // Cima
        { 0, -1 }, // Baixo
        { 1, -1 }, // Superior direito
        { -1, 1 }  // Inferior esquerdo
    };

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] results = new int[t];

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                results[i] = Solve(n);
            }

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }

        static int Solve(int n)
        {
            var dp = new Dictionary<(int, int, int), int>();
            return CountPaths(0, 0, n, dp);
        }

        static int CountPaths(int x, int y, int stepsLeft, Dictionary<(int, int, int), int> dp)
        {
            if (stepsLeft == 0)
                return (x == 0 && y == 0) ? 1 : 0;

            if (dp.ContainsKey((x, y, stepsLeft)))
                return dp[(x, y, stepsLeft)];

            int count = 0;

            for (int i = 0; i < 6; i++)
            {
                int newX = x + directions[i, 0];
                int newY = y + directions[i, 1];
                count += CountPaths(newX, newY, stepsLeft - 1, dp);
            }

            dp[(x, y, stepsLeft)] = count;
            return count;
        }
    }
}
