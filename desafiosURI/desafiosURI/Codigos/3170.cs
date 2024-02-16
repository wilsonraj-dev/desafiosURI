//https://judge.beecrowd.com/pt/problems/view/3170
using System;

namespace desafiosURI.Codigos
{
    internal class _3170
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            int G = int.Parse(Console.ReadLine());

            if (G % 2 != 0)
                G -= 1;

            int metade = G / 2;
            int bolinhas = metade - B;

            if (bolinhas > 0)
                Console.WriteLine($"Faltam {bolinhas} bolinha(s)");
            else
                Console.WriteLine("Amelia tem todas bolinhas!");
        }
    }
}
