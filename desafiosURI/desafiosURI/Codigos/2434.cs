//https://www.beecrowd.com.br/judge/pt/problems/view/2434
using System;

namespace desafiosURI.Codigos
{
    class _2434
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');
            int dias = int.Parse(dados[0]);
            int saldoInicial = int.Parse(dados[1]);

            int menorSaldo = saldoInicial;

            for (int i = 0; i < dias; i++)
            {
                int movimentacao = int.Parse(Console.ReadLine());
                saldoInicial += movimentacao;

                if (saldoInicial < menorSaldo)
                    menorSaldo = saldoInicial;
            }

            Console.WriteLine(menorSaldo);
        }
    }
}
