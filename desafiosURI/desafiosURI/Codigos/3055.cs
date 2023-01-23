//https://www.beecrowd.com.br/judge/pt/problems/view/3055
using System;

namespace desafiosURI.Codigos
{
    class _3055
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int segundaNota = (2 * m) - a;
            Console.WriteLine(segundaNota);
        }
    }
}
