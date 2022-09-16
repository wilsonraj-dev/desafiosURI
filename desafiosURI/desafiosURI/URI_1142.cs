using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI
{
    class URI_1142
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas 
               na execução do programa.

               Entrada
               O arquivo de entrada contém um número inteiro positivo N.
            
               Saída
               Imprima a saída conforme o exemplo fornecido. */

            int N = int.Parse(Console.ReadLine());
            int contador = 1;
            int numeroSequencia = 1;

            while (contador <= N)
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (numeroSequencia % 4 != 0)
                    {
                        Console.Write($"{numeroSequencia} ");
                        numeroSequencia++;
                    }
                    else if (numeroSequencia % 4 == 0)
                    {
                        Console.Write("PUM\n");
                        numeroSequencia++;
                    }
                }
                contador++;
            }
        }
    }
}
