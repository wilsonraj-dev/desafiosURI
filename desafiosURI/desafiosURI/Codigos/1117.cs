using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class URI_1117
    {
        /* Faça um programa que leia as notas referentes às duas avaliações de um aluno. 
           Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas 
           (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.
           
           Entrada
           A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando 
           forem lidas duas notas válidas.
            
           Saída
           Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
           Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " 
           seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal. */

        static void Main(string[] args)
        {
            int contador = 1;
            double somaNotas = 0;
            double media = 0;
            while (contador <= 2)
            {
                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (notas >= 0 && notas <= 10)
                {
                    somaNotas += notas;
                    contador++;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            media = somaNotas / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
