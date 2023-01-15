//https://www.beecrowd.com.br/judge/pt/problems/view/2061
using System;

namespace desafiosURI.Codigos
{
    class _2061
    {
        static void Main(string[] args)
        {

            string[] dados = Console.ReadLine().Split(' ');
            int abas = int.Parse(dados[0]);
            int acoes = int.Parse(dados[1]);

            for (int i = 0; i < acoes; i++)
            {
                string acao = Console.ReadLine();

                if (acao == "fechou")
                {
                    abas += 2 - 1;
                }
                else if (acao == "clicou")
                {
                    abas -= 1;
                }
                else
                {
                    Console.WriteLine("Valor de entrada inválido");
                }
            }
            Console.WriteLine(abas);
        }
    }
}
