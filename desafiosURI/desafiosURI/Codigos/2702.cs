//https://www.beecrowd.com.br/judge/pt/problems/view/2702
using System;

namespace desafiosURI.Codigos
{
    class _2702
    {
        static void Main(string[] args)
        {
            string[] v0 = Console.ReadLine().Split(' ');
            string[] v1 = Console.ReadLine().Split(' ');

            int ca = int.Parse(v0[0]);
            int ba = int.Parse(v0[1]);
            int pa = int.Parse(v0[2]);

            int cr = int.Parse(v1[0]);
            int br = int.Parse(v1[1]);
            int pr = int.Parse(v1[2]);
            int faltas = 0;

            if (cr > ca)
            {
                faltas += cr - ca;
            }
            if (br > ba)
            {
                faltas += br - ba;
            }
            if (pr > pa)
            {
                faltas += pr - pa;
            }

            Console.WriteLine(faltas);
        }
    }
}
