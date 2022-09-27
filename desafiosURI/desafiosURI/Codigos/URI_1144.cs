using System;

namespace desafiosURI.Codigos
{
    class URI_1144
    {
        /* Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa, seguindo a 
        lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.

        Entrada
        O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

        Saída
        Imprima a saída conforme o exemplo fornecido. */

        static void Main(string[] args)
        {
            double N = int.Parse(Console.ReadLine());
            double quadrado = 1;
            double multiplicador = 0;

            for (double i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} { quadrado = Math.Pow(i, 2)} {multiplicador = i * quadrado}");
                quadrado++;
                multiplicador++;
                Console.WriteLine($"{i} {quadrado} {multiplicador}");
            }
        }
    }
}
