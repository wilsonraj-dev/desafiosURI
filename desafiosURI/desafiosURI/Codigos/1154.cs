//https://www.beecrowd.com.br/judge/pt/problems/view/1154
using System;
using System.Globalization;
namespace desafiosURI.Codigos
{
    class _1154
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine());
            double somaIdades = 0;
            int quantidadeIdades = 0;
            double mediaIdades = 0;

            while (idade >= 0)
            {
                somaIdades += idade;
                idade = int.Parse(Console.ReadLine());
                quantidadeIdades++;
            }

            mediaIdades = somaIdades / quantidadeIdades;
            Console.WriteLine(mediaIdades.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
