//https://www.beecrowd.com.br/judge/pt/problems/view/1864
using System;

namespace desafiosURI.Codigos
{
    internal class _1864
    {
        static void Main(string[] args)
        {
            string mensagem = "LIFE IS NOT A PROBLEM TO BE SOLVED";
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(mensagem.Substring(0, N));
        }
    }
}
