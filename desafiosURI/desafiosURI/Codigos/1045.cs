//https://www.beecrowd.com.br/judge/pt/problems/view/1045
using System;

namespace desafiosURI
{
    class URI_1045
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double A = double.Parse(s[0]);
            double B = double.Parse(s[1]);
            double C = double.Parse(s[2]);
            double aux;

            if (B > A && B > C)
            {
                aux = A;
                A = B;
                B = aux;
            }
            else if (C > A)
            {
                aux = A;
                A = C;
                C = aux;
            }

            if (A >= (B + C))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (A * A == (B * B) + (C * C))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (A * A > (B * B) + (C * C))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (A * A < (B * B) + (C * C))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (A == B && A == C && B == C)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}