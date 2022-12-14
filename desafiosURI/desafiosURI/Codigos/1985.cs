//https://www.beecrowd.com.br/judge/pt/problems/view/1985
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _1985
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double valorPedido = 0;

            for (int i = 0; i < n; i++)
            {
                string[] variaveis = Console.ReadLine().Split(' ');
                int p = int.Parse(variaveis[0]);
                double q = int.Parse(variaveis[1]);

                if (p == 1001)
                    valorPedido += q * 1.50;
                else if (p == 1002)
                    valorPedido += q * 2.50;
                else if (p == 1003)
                    valorPedido += q * 3.50;
                else if (p == 1004)
                    valorPedido += q * 4.50;
                else if (p == 1005)
                    valorPedido += q * 5.50;
            }

            Console.WriteLine(valorPedido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
