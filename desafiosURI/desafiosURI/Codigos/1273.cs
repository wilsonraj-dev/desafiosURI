//https://www.beecrowd.com.br/judge/pt/problems/view/1273
using System;
using System.Collections.Generic;

namespace desafiosURI.Codigos
{
    internal class _1273
    {
        static void Main()
        {
            bool primeiroCaso = true;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    break;

                if (primeiroCaso)
                {
                    primeiroCaso = false;
                }
                else
                {
                    Console.WriteLine();
                }

                List<string> palavras = new List<string>();
                int larguraMaxima = 0;

                for (int i = 0; i < n; i++)
                {
                    string palavra = Console.ReadLine();
                    palavras.Add(palavra);
                    if (palavra.Length > larguraMaxima)
                    {
                        larguraMaxima = palavra.Length;
                    }
                }

                // Imprimir palavras alinhadas à direita
                foreach (string palavra in palavras)
                {
                    string espacos = new string(' ', larguraMaxima - palavra.Length);
                    Console.WriteLine(espacos + palavra);
                }
            }
        }
    }
}
