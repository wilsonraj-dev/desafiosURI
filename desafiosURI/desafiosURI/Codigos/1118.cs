//https://www.beecrowd.com.br/judge/pt/problems/view/1118
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class URI_1118
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            while (opcao == 1)
            {
                double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n1 < 0 || n1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n2 < 0 || n2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (n1 + n2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}