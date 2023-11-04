//https://www.beecrowd.com.br/judge/pt/problems/view/1069
using System;

namespace desafiosURI.Codigos
{
    internal class _1069
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int contaDiamante = 0, troca = 1;
                string diamante = Console.ReadLine();

                diamante = diamante.Replace(".", "");

                while (troca == 1)
                {
                    if (diamante.IndexOf("<>") != -1)
                    {
                        contaDiamante++;
                        diamante = diamante.ReplaceFirst("<>", "");
                    }
                    else
                    {
                        troca = 0;
                    }
                }

                Console.WriteLine(contaDiamante);
            }
        }
    }

    public static class Extension
    {
        public static string ReplaceFirst(this string str, string term, string replace)
        {
            int position = str.IndexOf(term);

            if (position < 0)
            {
                return str;
            }
            str = str.Substring(0, position) + replace + str.Substring(position + term.Length);
            return str;
        }
    }
}
