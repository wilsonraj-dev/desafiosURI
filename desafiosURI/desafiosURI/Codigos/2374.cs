//https://www.beecrowd.com.br/judge/pt/problems/view/2374
using System;

namespace desafiosURI.Codigos
{
    class _2374
    {
        static void Main(string[] args)
        {
            int pressaoDesejada = int.Parse(Console.ReadLine());
            int pressaoDaBomba = int.Parse(Console.ReadLine());

            int resultadoFinal = pressaoDesejada - pressaoDaBomba;
            Console.WriteLine(resultadoFinal);
        }
    }
}
