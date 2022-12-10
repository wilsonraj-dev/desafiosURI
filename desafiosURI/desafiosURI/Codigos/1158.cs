using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI.Codigos
{
    class _1158
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);
                int contador = 0;
                int soma = 0;

                while (contador < y)
                {
                    if (x % 2 != 0)
                    {
                        soma += x;
                        contador++;
                    }
                    x++;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
