//https://www.beecrowd.com.br/judge/pt/problems/view/1153
using System;

namespace desafiosURI
{
    class URI_1153
    {
        static void Main(string[] args)
        {
            int N, fat = 1;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                fat *= i;
            }
            Console.WriteLine(fat);
            Console.ReadLine();
        }
    }
}