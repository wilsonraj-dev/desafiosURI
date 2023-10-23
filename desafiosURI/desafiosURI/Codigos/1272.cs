//https://www.beecrowd.com.br/judge/pt/problems/view/1272
using System;

class _1272
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string textoConvertido = "";
            string[] entrada = Console.ReadLine().Split(' ');

            for (int j = 0; j < entrada.Length; j++)
            {
                if (string.IsNullOrEmpty(entrada[j])) continue;

                textoConvertido += entrada[j].Substring(0, 1);
            }

            Console.WriteLine(textoConvertido);
        }
    }
}