using System;

namespace desafiosURI.Codigos
{
    class URI_1095
    {
        /* Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

        Entrada
        Não há nenhuma entrada neste problema.

        Saída
        Imprima a sequencia conforme exemplo abaixo */


        static void Main(string[] args)
        {

            int i = 1;
            for (int j = 60; j >= 0; j = j - 5)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i = i + 3;
            }

        }
    }
}
