//https://www.beecrowd.com.br/judge/pt/problems/view/1041
using System;

namespace desafiosURI.Codigos
{
    class URI_1041
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);

            if (n1 == 0 && n2 == 0)
                Console.WriteLine("Origem");
            else if (n1 == 0)
                Console.WriteLine("Eixo Y");
            else if (n2 == 0)
                Console.WriteLine("Eixo X");
            else if (n1 > 0 && n2 > 0)
                Console.WriteLine("Q1");
            else if (n1 < 0 && n2 > 0)
                Console.WriteLine("Q2");
            else if (n1 < 0 && n2 < 0)
                Console.WriteLine("Q3");
            else if (n1 > 0 && n2 < 0)
                Console.WriteLine("Q4");
        }
    }
}