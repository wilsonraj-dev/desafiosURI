//https://www.beecrowd.com.br/judge/pt/problems/view/1848
using System;

namespace desafiosURI.Codigos
{
    internal class _1848
    {
        static void Main(string[] args)
        {
            int numero, flag;
            string corvo = "";

            for (int i = 0; i < 3; i++)
            {
                numero = 0;
                flag = 0;

                while (flag == 0)
                {
                    corvo = Console.ReadLine();
                    switch (corvo)
                    {
                        case "--*": numero += 1; break;
                        case "-*-": numero += 2; break;
                        case "-**": numero += 3; break;
                        case "*--": numero += 4; break;
                        case "*-*": numero += 5; break;
                        case "**-": numero += 6; break;
                        case "***": numero += 7; break;
                        default: flag = 1; break;
                    }
                }

                Console.WriteLine(numero);
            }
        }
    }
}
