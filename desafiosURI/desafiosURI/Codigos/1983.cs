//https://www.beecrowd.com.br/judge/pt/problems/view/1983
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    internal class _1983
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int matricula = 0;
            double maior = 0;

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                int numeroMatricula = int.Parse(v[0]);
                double nota = double.Parse(v[1], CultureInfo.InvariantCulture);

                if (nota > maior)
                {
                    matricula = numeroMatricula;
                    maior = nota;
                }
            }

            if (maior < 8)
                Console.WriteLine("Minimum note not reached");
            else
                Console.WriteLine(matricula);
        }
    }
}
