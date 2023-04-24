//https://www.beecrowd.com.br/judge/pt/problems/view/2062
using System;

namespace desafiosURI.Codigos
{
    internal class _2062
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] palavra = Console.ReadLine().Split(' ');

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i].Length == 3)
                {
                    if (palavra[i].StartsWith("OB") || palavra[i].StartsWith("UR") && !palavra[i].EndsWith("I"))
                    {
                        palavra[i] = palavra[i].Substring(0, 2) + "I";
                    }
                }
            }

            Console.WriteLine(string.Join(" ", palavra));
        }
    }
}
