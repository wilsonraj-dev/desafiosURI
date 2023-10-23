//https://www.beecrowd.com.br/judge/pt/problems/view/1257
using System;
using System.Collections.Generic;

class _1257
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, int> dicValores = CapturarValores();

        for (int i = 0; i < N; i++)
        {
            int L = int.Parse(Console.ReadLine());
            int valor = 0;
            int elemento = 0;

            for (int j = 0; j < L; j++)
            {
                string sequencia = Console.ReadLine().ToUpper();
                char[] sequenciaArray = sequencia.ToCharArray();

                for (int k = 0; k < sequencia.Length; k++)
                {
                    valor += (dicValores[sequenciaArray.GetValue(k).ToString()] + elemento + k);
                }

                elemento++;
            }

            Console.WriteLine(valor);
        }
    }

    public static Dictionary<string, int> CapturarValores()
    {
        return new Dictionary<string, int>
        {
            { "A", 0 },
            { "B", 1 },
            { "C", 2 },
            { "D", 3 },
            { "E", 4 },
            { "F", 5 },
            { "G", 6 },
            { "H", 7 },
            { "I", 8 },
            { "J", 9 },
            { "K", 10 },
            { "L", 11 },
            { "M", 12 },
            { "N", 13 },
            { "O", 14 },
            { "P", 15 },
            { "Q", 16 },
            { "R", 17 },
            { "S", 18 },
            { "T", 19 },
            { "U", 20 },
            { "V", 21 },
            { "W", 22 },
            { "X", 23 },
            { "Y", 24 },
            { "Z", 25 }
        };
    }
}