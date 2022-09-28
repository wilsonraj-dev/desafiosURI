//https://www.beecrowd.com.br/judge/pt/problems/view/1173
using System;

namespace desafiosURI.Codigos
{
    class _1173
    {
        static void Main(string[] args)
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] N = new int[10];
            int j = valorLido;
            for (int i = 0; i < 10; i++)
            {
                N[i] = i;
                Console.WriteLine("N" + "[" + N[i] + "]" + " = " + j);
                j *= 2;
            }
        }
    }
}