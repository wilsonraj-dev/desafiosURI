using System;

namespace desafiosURI.Codigos
{
    class URI_1041
    {
        /* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de 
        um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está 
        sobre um dos eixos cartesianos ou na origem (x = y = 0).
           
        Se o ponto estiver na origem, escreva a mensagem “Origem”.
           
        Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
           
        Entrada
        A entrada contem as coordenadas de um ponto.
           
        Saída
        A saída deve apresentar o quadrante em que o ponto se encontra. */

        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);

            if (n1 == 0 && n2 == 0)
                Console.WriteLine("Origem");
            else if (n1 == 0)
                Console.WriteLine("Eixo Y");
            else if (n2 == 0)
                Console.WriteLine("Eixo X");
            else if (n1 > 0 && n2 > 0)
                Console.WriteLine("Q1");
            else if (n1 < 0 && n2 > 0)
                Console.WriteLine("Q2");
            else if (n1 < 0 && n2 < 0)
                Console.WriteLine("Q3");
            else if (n1 > 0 && n2 < 0)
                Console.WriteLine("Q4");
        }
    }
}
