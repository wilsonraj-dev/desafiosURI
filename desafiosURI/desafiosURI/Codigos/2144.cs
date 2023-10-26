//https://www.beecrowd.com.br/judge/pt/problems/view/2144
using System;

namespace desafiosURI.Codigos
{
    internal class _2144
    {
        static void Main()
        {
            double mediaDosCasos = 0;
            int count = 0;

            while (true)
            {
                string[] v = Console.ReadLine().Split(' ');

                int W1 = int.Parse(v[0]);
                int W2 = int.Parse(v[1]);
                int R = int.Parse(v[2]);

                if (W1 == 0 && W2 == 0 && R == 0)
                    break;

                double W = (W1 + W2) / 2.0;
                double media = W * (1 + (R / 30.0));

                if (media >= 1 && media <= 13)
                    Console.WriteLine("Nao vai da nao");
                else if (media >= 13 && media < 14)
                    Console.WriteLine("E 13");
                else if (media >= 14 && media < 40)
                    Console.WriteLine("Bora, hora do show! BIIR!");
                else if (media >= 40 && media <= 60)
                    Console.WriteLine("Ta saindo da jaula o monstro!");
                else
                    Console.WriteLine("AQUI E BODYBUILDER!!");

                mediaDosCasos += media;
                count++;
            }

            if (mediaDosCasos / count > 40)
            {
                Console.WriteLine();
                Console.WriteLine("Aqui nois constroi fibra rapaz! Nao e agua com musculo!");
            }
        }
    }
}
