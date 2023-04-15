//https://www.beecrowd.com.br/judge/pt/problems/view/1041
using System;

namespace desafiosURI.Codigos
{
    class _2221
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int bonus = int.Parse(Console.ReadLine());

                string[] Dabriel = Console.ReadLine().Split(' ');
                int ataqueDabriel = int.Parse(Dabriel[0]);
                int defesaDabriel = int.Parse(Dabriel[1]);
                int levelDabriel = int.Parse(Dabriel[2]);

                string[] Guarte = Console.ReadLine().Split(' ');
                int ataqueGuarte = int.Parse(Guarte[0]);
                int defesaGuarte = int.Parse(Guarte[1]);
                int levelGuarte = int.Parse(Guarte[2]);

                double valorGolpeDabriel = ((ataqueDabriel + defesaDabriel) / 2) + (levelDabriel % 2 == 0 ? bonus : 0);
                double valorGolpeGuarte = ((ataqueGuarte + defesaGuarte) / 2) + (levelGuarte % 2 == 0 ? bonus : 0);

                if (valorGolpeDabriel > valorGolpeGuarte)
                    Console.WriteLine("Dabriel");
                else if (valorGolpeGuarte > valorGolpeDabriel)
                    Console.WriteLine("Guarte");
                else
                    Console.WriteLine("Empate");
            }
        }
    }
}