﻿using System;

namespace desafiosURI.Codigos
{
    class _2717
    {
        static void Main(string[] args)
        {
            /* A fabricação dos presentes para o Natal é um processo muito complicado. Diversas vezes os duendes ficam até tarde trabalhando 
            para que tudo possa ser terminado a tempo e com perfeição.

            Para melhor gerenciar seus cronogramas, os duendes estipularam quantos minutos são necessários para fabricar cada presente.

            Já está quase no final do expediente, e um dos duendes pediu sua ajuda.

            Faltam N minutos para a hora de ir embora, e restam dois presentes para o duende Ed fabricar. Ajude-o a descobrir se ele conseguirá fabricar 
            os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

            Entrada
            Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente (2 <= N <= 100).

            Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes 
            que Ed precisa fabricar (1 <= A, B <= 100).

            Saída
            Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, 
            ou "Deixa para amanha!" caso contrário. */

            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');

            int finalExpediente = int.Parse(line1[0]);

            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            int totalNecessario = presente1 + presente2;

            if (totalNecessario > finalExpediente)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }
        }
    }
}
