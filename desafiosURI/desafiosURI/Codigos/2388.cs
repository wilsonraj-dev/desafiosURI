//https://www.beecrowd.com.br/judge/pt/problems/view/2388
using System;

namespace desafiosURI.Codigos
{
    class _2388
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 0; i < n; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int t = int.Parse(numeros[0]);
                int v = int.Parse(numeros[1]);
                resultado = resultado + (t * v);
            }
            Console.WriteLine(resultado);
        }
    }
}
