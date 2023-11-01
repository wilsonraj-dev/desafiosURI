//https://www.beecrowd.com.br/judge/pt/problems/view/3348
using System;

namespace desafiosURI.Codigos
{
    internal class _3348
    {
        static void Main(string[] args)
        {

            string[] l = new string[]
            {
            "2", "7", "5", "30", "169", "441", "1872", "7632", "1740", "93313", "459901", "1358657", "2504881", "13482720", "25779600", "68468401", "610346880", "1271932200", "327280800"
            };

            int input = int.Parse(Console.ReadLine());
            int index = input - 1;

            if (index >= 0 && index < l.Length)
            {
                Console.WriteLine(l[index]);
            }

        }
    }
}
