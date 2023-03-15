//https://www.beecrowd.com.br/judge/pt/problems/view/1332
using System;

namespace desafiosURI.Codigos
{
    class _1332
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string entrada = Console.ReadLine();
                if (entrada.Equals("one"))
                    Console.WriteLine("1");
                else if (entrada.Equals("two"))
                    Console.WriteLine("2");
                else if (entrada.Equals("three"))
                    Console.WriteLine("3");
                else
                {
                    char[] x = entrada.ToCharArray();
                    if (x[0] == 'o' && x[1] == 'n')
                        Console.WriteLine("1");
                    else if (x[0] == 'o' && x[2] == 'e')
                        Console.WriteLine("1");
                    else if (x[1] == 'n' && x[2] == 'e')
                        Console.WriteLine("1");
                    else if (x[0] == 't' && x[1] == 'w')
                        Console.WriteLine("2");
                    else if (x[0] == 't' && x[2] == 'o')
                        Console.WriteLine("2");
                    else if (x[1] == 'w' && x[2] == 'o')
                        Console.WriteLine("2");
                    else if (x[0] == 't' && x[1] == 'h' && x[2] == 'r' && x[3] == 'e')
                        Console.WriteLine("3");
                    else if (x[0] == 't' && x[1] == 'h' && x[2] == 'r' && x[4] == 'e')
                        Console.WriteLine("3");
                    else if (x[0] == 't' && x[1] == 'h' && x[3] == 'e' && x[4] == 'e')
                        Console.WriteLine("3");
                    else if (x[0] == 't' && x[2] == 'r' && x[3] == 'e' && x[4] == 'e')
                        Console.WriteLine("3");
                    else if (x[1] == 'h' && x[2] == 'r' && x[3] == 'e' && x[4] == 'e')
                        Console.WriteLine("3");
                }
            }
        }
    }
}
