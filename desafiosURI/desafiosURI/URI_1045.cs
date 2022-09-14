﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI
{
    class URI_1045
    {
        static void Main(string[] args)
        {
            /* Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
             A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, 
             sempre escrevendo uma mensagem adequada:
             
             ° se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
             ° se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
             ° se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
             ° se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
             ° se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
             ° se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
               
             Entrada
             A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
             
             Saída
             Imprima todas as classificações do triângulo especificado na entrada. */

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
