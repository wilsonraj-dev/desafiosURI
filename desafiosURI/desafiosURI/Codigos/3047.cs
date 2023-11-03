//https://www.beecrowd.com.br/judge/pt/problems/view/3047
using System;

namespace desafiosURI.Codigos
{
    internal class _3047
    {
        public static void Main(string[] args)
        {
            int idadeMonica = int.Parse(Console.ReadLine());
            int idadeFilho1 = int.Parse(Console.ReadLine());
            int idadeFilho2 = int.Parse(Console.ReadLine());

            int idadeFilho3 = idadeMonica - (idadeFilho1 + idadeFilho2);

            if (idadeFilho1 > idadeFilho2 && idadeFilho1 > idadeFilho3)
                Console.WriteLine(idadeFilho1);
            else if (idadeFilho2 > idadeFilho1 && idadeFilho2 > idadeFilho3)
                Console.WriteLine(idadeFilho2);
            else
                Console.WriteLine(idadeFilho3);
        }
    }
}
