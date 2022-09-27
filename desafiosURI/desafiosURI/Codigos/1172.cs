using System;

namespace desafiosURI
{
    class URI_1172
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1. 
               Em seguida mostre o vetor X.

               Entrada
               A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.

               Saída
               Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição. */

            int[] vetorX = new int[10];

            for (int i = 0; i < vetorX.Length; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                vetorX[i] = valores;

                if (vetorX[i] == 0 || vetorX[i] < 0)
                    vetorX[i] = 1;

                Console.WriteLine($"X[{i}] = {vetorX[i]}");
            }
        }
    }
}
