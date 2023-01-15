//https://www.beecrowd.com.br/judge/pt/problems/view/2339
using System;

namespace desafiosURI.Codigos
{
    class _2339
    {
        static void Main(string[] args)
        {

            string[] dados = Console.ReadLine().Split(' ');
            int competidores = int.Parse(dados[0]);
            int folhas = int.Parse(dados[1]);
            int folhasUsadas = int.Parse(dados[2]);

            if (folhasUsadas * competidores > folhas)
                Console.WriteLine("N");
            else
                Console.WriteLine("S");

        }
    }
}
