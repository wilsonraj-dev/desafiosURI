//https://www.beecrowd.com.br/judge/pt/problems/view/1145
using System;

namespace desafiosURI.Codigos
{
    class _1145
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int X, Y, J = 0;
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);
            for (int i = 1; i <= Y; i++)
            {
                J++;
                Console.Write(i);
                if (J == X || i == Y)
                {
                    Console.Write("\n");
                    J = 0;
                }
                else
                    Console.Write(" ");
            }
        }
    }
}