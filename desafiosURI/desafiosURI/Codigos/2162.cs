//https://judge.beecrowd.com/pt/problems/view/2162
using System;

namespace desafiosURI.Codigos
{
    internal class _2169
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] H = Console.ReadLine().Split(' ');
            int padrao = 0;


            if (N > 2)
            {
                for (int i = 2; i < N; i++)
                {
                    if ((int.Parse(H[i - 2]) > int.Parse(H[i - 1]) && int.Parse(H[i - 1]) < int.Parse(H[i])) || (int.Parse(H[i - 2]) < int.Parse(H[i - 1]) && int.Parse(H[i - 1]) > int.Parse(H[i])))
                    {
                        padrao = 1;
                    }
                    else
                    {
                        padrao = 0;
                        break;
                    }
                }
            }
            else
            {
                if (H[0] != H[1]) padrao = 1;
            }

            Console.WriteLine(padrao);
        }
    }
}
