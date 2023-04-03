//https://www.beecrowd.com.br/judge/pt/problems/view/1914
using System;

namespace desafiosURI.Codigos
{
    class _1914
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                string jogador1 = vet[0];
                string jogador2 = vet[2];
                string escolharJogador1 = vet[1].ToUpper();
                string escolharJogador2 = vet[3].ToUpper();

                string[] valores = Console.ReadLine().Split(' ');
                int vlr1 = int.Parse(valores[0]);
                int vlr2 = int.Parse(valores[1]);

                if ((vlr1 + vlr2) % 2 == 0)
                {
                    if (escolharJogador1 == "PAR")
                        Console.WriteLine(jogador1);
                    else if (escolharJogador2 == "PAR")
                        Console.WriteLine(jogador2);
                }
                else if ((vlr1 + vlr2) % 2 == 1)
                {
                    if (escolharJogador1 == "IMPAR")
                        Console.WriteLine(jogador1);
                    else if (escolharJogador2 == "IMPAR")
                        Console.WriteLine(jogador2);
                }
            }
        }
    }
}
