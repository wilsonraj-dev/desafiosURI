//https://www.beecrowd.com.br/judge/pt/problems/view/2936
using System;

namespace desafiosURI.Codigos
{
    class _2936
    {
        static void Main(string[] args)
        {
            int curupira = int.Parse(Console.ReadLine());
            int boitata = int.Parse(Console.ReadLine());
            int boto = int.Parse(Console.ReadLine());
            int mapinguari = int.Parse(Console.ReadLine());
            int iara = int.Parse(Console.ReadLine());
            int porcaoFinal = 0;

            porcaoFinal = curupira * 300;
            porcaoFinal += boitata * 1500;
            porcaoFinal += boto * 600;
            porcaoFinal += mapinguari * 1000;
            porcaoFinal += iara * 150;
            porcaoFinal += 225;

            Console.WriteLine(porcaoFinal);

        }
    }
}
