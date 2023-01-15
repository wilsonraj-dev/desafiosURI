//https://www.beecrowd.com.br/judge/pt/problems/view/2416
using System;

namespace desafiosURI.Codigos
{
    class _2416
    {
        static void Main(string[] args)
        {

            string[] dados = Console.ReadLine().Split(' ');
            int m = int.Parse(dados[0]);
            int n = int.Parse(dados[1]);

            int resultado = m % n;
            Console.WriteLine(resultado);

        }
    }
}
