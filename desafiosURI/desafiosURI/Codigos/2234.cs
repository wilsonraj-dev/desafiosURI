//https://www.beecrowd.com.br/judge/pt/problems/view/2234
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _2234
    {
        class URI
        {

            static void Main(string[] args)
            {

                string[] vet = Console.ReadLine().Split(' ');

                double vlr1 = int.Parse(vet[0]);
                double vlr2 = int.Parse(vet[1]);

                Console.WriteLine((vlr1 / vlr2).ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
