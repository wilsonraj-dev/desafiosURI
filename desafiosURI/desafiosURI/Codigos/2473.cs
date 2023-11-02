//https://www.beecrowd.com.br/judge/pt/problems/view/2473
using System;
using System.Linq;

namespace desafiosURI.Codigos
{
    internal class _2473
    {
        public static void Main(string[] args)
        {
            string[] numerosFlavinho = Console.ReadLine().Split(' ');
            string[] numerosSorteados = Console.ReadLine().Split(' ');

            var acertos = numerosFlavinho.Intersect(numerosSorteados);
            if (acertos.Count() < 3)
                Console.WriteLine("azar");
            else if (acertos.Count() == 3)
                Console.WriteLine("terno");
            else if (acertos.Count() == 4)
                Console.WriteLine("quadra");
            else if (acertos.Count() == 5)
                Console.WriteLine("quina");
            else if (acertos.Count() == 6)
                Console.WriteLine("sena");
        }
    }
}
