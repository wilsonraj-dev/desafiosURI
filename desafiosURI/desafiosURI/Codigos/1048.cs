//https://www.beecrowd.com.br/judge/pt/problems/view/1048
using System;
using System.Globalization;

namespace desafiosURI
{
    class URI_1048
    {
        static void Main(string[] args)
        {
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