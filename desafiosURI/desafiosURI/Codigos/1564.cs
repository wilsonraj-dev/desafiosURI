//https://www.beecrowd.com.br/judge/pt/problems/view/1564
using System;

namespace desafiosURI.Codigos
{
    class _1564
    {
        static void Main(string[] args)
        {
            string str;
            while ((str = Console.ReadLine()) != null)
            {

                int x = int.Parse(str);
                if (x == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}