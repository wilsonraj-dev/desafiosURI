//https://www.beecrowd.com.br/judge/pt/problems/view/1156
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _1156
    {
        static void Main(string[] args)
        {
            double n = 0, i, x = 1;

            for (i = 1; i < 39; i += 2)
            {
                if (i == 1)
                {
                    n += 1;
                }
                else
                {
                    x *= 2;
                    n += (i / x);
                }
            }
            Console.WriteLine(n.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
