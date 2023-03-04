//https://www.beecrowd.com.br/judge/pt/problems/view/1847
using System;

namespace desafiosURI.Codigos
{
    class _1847
    {
        static void Main(string[] args)
        {
            string[] temperaturas = Console.ReadLine().Split(' ');
            int A = int.Parse(temperaturas[0]);
            int B = int.Parse(temperaturas[1]);
            int C = int.Parse(temperaturas[2]);

            if (B < A && C >= B) Console.WriteLine(":)");
            else if (B > A && C <= B) Console.WriteLine(":(");
            else if (B > A && C > B && (C - B) < (B - A)) Console.WriteLine(":(");
            else if (B > A && C > B && (C - B) >= (B - A)) Console.WriteLine(":)");
            else if (B < A && C < B && (B - C) < (A - B)) Console.WriteLine(":)");
            else if (B < A && C < B && (B - C) >= (A - B)) Console.WriteLine(":(");
            else if (B == A && C > B) Console.WriteLine(":)");
            else if (B == A && C < B) Console.WriteLine(":(");
            else Console.WriteLine(":(");
        }
    }
}
