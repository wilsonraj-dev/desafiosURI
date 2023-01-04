//https://www.beecrowd.com.br/judge/pt/problems/view/2006
using System;

namespace desafiosURI.Codigos
{
    class _2006
    {
        static void Main(string[] args)
        {
            int tipoCha = int.Parse(Console.ReadLine());
            string[] respostas = Console.ReadLine().Split(' ');
            int contador = 0;

            int a = int.Parse(respostas[0]);
            int b = int.Parse(respostas[1]);
            int c = int.Parse(respostas[2]);
            int d = int.Parse(respostas[3]);
            int e = int.Parse(respostas[4]);

            if (tipoCha == a)
                contador++;
            if (tipoCha == b)
                contador++;
            if (tipoCha == c)
                contador++;
            if (tipoCha == d)
                contador++;
            if (tipoCha == e)
                contador++;

            Console.WriteLine(contador);
        }
    }
}
