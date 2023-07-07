//https://www.beecrowd.com.br/judge/pt/problems/view/3301
using System;

namespace desafiosURI.Codigos
{
    internal class _3301
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            int H = int.Parse(v[0]);
            int Z = int.Parse(v[1]);
            int L = int.Parse(v[2]);

            if ((Z > H && Z < L) || (Z < H && Z > L))
                Console.WriteLine("zezinho");
            else if ((L > H && L < Z) || (L < H && L > Z))
                Console.WriteLine("luisinho");
            else
                Console.WriteLine("huguinho");
        }
    }
}
