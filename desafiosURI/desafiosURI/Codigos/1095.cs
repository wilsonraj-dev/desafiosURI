//https://www.beecrowd.com.br/judge/pt/problems/view/1095
using System;

namespace desafiosURI.Codigos
{
    class URI_1095
    {
        static void Main(string[] args)
        {

            int i = 1;
            for (int j = 60; j >= 0; j = j - 5)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i = i + 3;
            }

        }
    }
}