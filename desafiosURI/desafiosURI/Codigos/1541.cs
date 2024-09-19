//https://judge.beecrowd.com/pt/problems/view/1541
using System;

namespace desafiosURI.Codigos
{
    internal class _1541
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            while (A != 0)
            {
                int B = int.Parse(vet[1]);
                double C = double.Parse(vet[2]);

                int medidaMedia = A * B;
                double percentualMaximo = C / 100;

                double areaMinima = medidaMedia / percentualMaximo;
                double ladoTerreno = Math.Sqrt(areaMinima);

                Console.WriteLine(Math.Truncate(ladoTerreno));

                vet = Console.ReadLine().Split(' ');

                A = int.Parse(vet[0]);
            }
        }
    }
}
