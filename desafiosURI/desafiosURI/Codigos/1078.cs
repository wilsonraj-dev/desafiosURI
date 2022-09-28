//https://www.beecrowd.com.br/judge/pt/problems/view/1078
using System;

namespace desafiosURI
{
    class URI_1078
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * n;
                Console.Write(i + " x " + n + " = " + resultado);
                Console.ReadLine();
            }
        }
    }
}