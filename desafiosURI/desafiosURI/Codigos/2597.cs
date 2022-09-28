//https://www.beecrowd.com.br/judge/pt/problems/view/2597
using System;

namespace desafiosURI.Codigos
{
    class _2597
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);
                int answer = val - newval;
                Console.WriteLine(answer);
            }
        }
    }
}