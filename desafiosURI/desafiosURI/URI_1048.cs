using System;
using System.Globalization;

namespace desafiosURI
{
    class URI_1048
    {
        static void Main(string[] args)
        {
            /* A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
             
                                       ----------------------------------------------
                                       |      Salário      | Percentual de Reajuste |
                                       | -------------------------------------------|
                                       | 0 - 400.00        |          15 %          |
                                       | 400.01 - 800.00   |          12 %          |
                                       | 800.01 - 1200.00  |          10 %          |
                                       | 1200.01 - 2000.00 |           7 %          |
                                       | Acima de 2000.00  |           4 %          |
                                       ---------------------------------------------
                                                

            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

            Entrada
            A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

            Saída
            Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) 
            e o percentual de reajuste ganho, conforme exemplo abaixo. */

            double salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ajusteSalarial = 0;
            double salarioReajustado = 0;

            if (salarioAtual >= 0 && salarioAtual <= 400.00)
            {
                ajusteSalarial = salarioAtual * 0.15;
                salarioReajustado = salarioAtual + ajusteSalarial;
                Console.WriteLine("Novo salario: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                ajusteSalarial = salarioAtual * 0.12;
                salarioReajustado = salarioAtual + ajusteSalarial;
                Console.WriteLine("Novo salario: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                ajusteSalarial = salarioAtual * 0.10;
                salarioReajustado = salarioAtual + ajusteSalarial;
                Console.WriteLine("Novo salario: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                ajusteSalarial = salarioAtual * 0.07;
                salarioReajustado = salarioAtual + ajusteSalarial;
                Console.WriteLine("Novo salario: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salarioAtual > 2000.00)
            {
                ajusteSalarial = salarioAtual * 0.04;
                salarioReajustado = salarioAtual + ajusteSalarial;
                Console.WriteLine("Novo salario: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
