//https://www.beecrowd.com.br/judge/pt/problems/view/1858
using System;

namespace desafiosURI.Codigos
{
    class _1858
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split();

            int minIndex = 0;
            int minValue = int.Parse(t[0]);

            for (int i = 1; i < n; i++)
            {
                int value = int.Parse(t[i]);

                if (value < minValue)
                {
                    minIndex = i;
                    minValue = value;
                }
            }

            Console.WriteLine(minIndex + 1);
        }
    }
}
