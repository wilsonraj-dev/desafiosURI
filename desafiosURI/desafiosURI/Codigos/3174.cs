//https://judge.beecrowd.com/pt/problems/view/3174
using System;

namespace desafiosURI.Codigos
{
    internal class _3174
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int countBonecos = 0;
            int countArquitetos = 0;
            int countMusicos = 0;
            int countDesenhistas = 0;


            for (int i = 0; i < N; i++)
            {
                string[] vt = Console.ReadLine().Split(' ');

                string E = vt[0];
                string G = vt[1];
                int H = int.Parse(vt[2]);

                switch (G)
                {
                    case "bonecos":
                        countBonecos += H;
                        break;
                    case "arquitetos":
                        countArquitetos += H;
                        break;
                    case "musicos":
                        countMusicos += H;
                        break;
                    case "desenhistas":
                        countDesenhistas += H;
                        break;
                    default: break;
                }
            }

            int P = ((countBonecos / 8) + (countArquitetos / 4) + (countMusicos / 6) + (countDesenhistas / 12));
            Console.WriteLine(P);
        }
    }
}
