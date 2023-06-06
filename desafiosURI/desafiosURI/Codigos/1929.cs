//https://www.beecrowd.com.br/judge/pt/problems/view/1929
using System;

namespace desafiosURI.Codigos
{
    class _1929
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            int A = int.Parse(v[0]);
            int B = int.Parse(v[1]);
            int C = int.Parse(v[2]);
            int D = int.Parse(v[3]);

            if ((A < (B + C)) && (A > Math.Abs(B - C)) ||
                (A < (B + D)) && (A > Math.Abs(B - D)) ||
                (A < (C + D)) && (A > Math.Abs(C - D)) ||
                (B < (A + C)) && (B > Math.Abs(A - C)) ||
                (B < (A + D)) && (B > Math.Abs(A - D)) ||
                (B < (C + D)) && (B > Math.Abs(C - D)) ||
                (C < (A + B)) && (C > Math.Abs(A - B)) ||
                (C < (A + D)) && (C > Math.Abs(A - D)) ||
                (C < (B + D)) && (C > Math.Abs(B - D)) ||
                (D < (A + B)) && (D > Math.Abs(A - B)) ||
                (D < (A + C)) && (D > Math.Abs(A - C)) ||
                (D < (B + C)) && (D > Math.Abs(B - C)))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
