//https://www.beecrowd.com.br/judge/pt/problems/view/1185
using System;

namespace desafiosURI.Codigos
{
    class _1185
    {
        static void Main(string[] args)
        {
            char operacao = char.Parse(Console.ReadLine());
            int elementosAcimaDiagonal = 0;
            double total = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double valor = double.Parse(Console.ReadLine());

                    if (i + j < 11)
                    {
                        total += valor;
                        elementosAcimaDiagonal++;
                    }
                }
            }


            if (operacao == 'S')
            {
                Console.WriteLine(total.ToString("F1"));
            }
            else if (operacao == 'M')
            {
                double media = total / elementosAcimaDiagonal;
                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
