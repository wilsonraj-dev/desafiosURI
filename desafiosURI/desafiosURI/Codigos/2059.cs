//https://www.beecrowd.com.br/judge/pt/problems/view/2059
using System;

namespace desafiosURI.Codigos
{
    class _2059
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            int par = int.Parse(v[0]);
            int j1 = int.Parse(v[1]);
            int j2 = int.Parse(v[2]);
            int roubou = int.Parse(v[3]);
            int acusouRoubo = int.Parse(v[4]);

            if (roubou == 1 && acusouRoubo == 1)
                Console.WriteLine("Jogador 2 ganha!");
            else if (roubou == 1 && acusouRoubo == 0)
                Console.WriteLine("Jogador 1 ganha!");
            else if (roubou == 0 && acusouRoubo == 1)
                Console.WriteLine("Jogador 1 ganha!");
            else if (par == 0 && (j1 + j2) % 2 != 0)
                Console.WriteLine("Jogador 1 ganha!");
            else if (par == 1 && (j1 + j2) % 2 == 0)
                Console.WriteLine("Jogador 1 ganha!");
            else
                Console.WriteLine("Jogador 2 ganha!");
        }
    }
}
