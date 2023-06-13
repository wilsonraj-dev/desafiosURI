//https://www.beecrowd.com.br/judge/pt/problems/view/1963
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _1963
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            double A = double.Parse(v[0]);
            double B = double.Parse(v[1]);

            double valor = ((B - A) / A) * 100;
            Console.WriteLine($"{valor.ToString("F2", CultureInfo.InvariantCulture)}%");
        }
    }
}
