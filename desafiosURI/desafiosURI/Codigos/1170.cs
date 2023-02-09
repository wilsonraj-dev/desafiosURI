//https://www.beecrowd.com.br/judge/pt/problems/view/1170
using System;

namespace desafiosURI.Codigos
{
    class _1170
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double comida = double.Parse(Console.ReadLine());
                int cont = 0;
                while (comida > 1)
                {
                    comida = comida / 2;
                    cont++;
                }
                Console.WriteLine($"{cont} dias");
            }
        }
    }
}
