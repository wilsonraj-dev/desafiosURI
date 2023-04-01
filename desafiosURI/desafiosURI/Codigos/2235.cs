//https://www.beecrowd.com.br/judge/pt/problems/view/2235
using System;
using System.Linq;

namespace desafiosURI.Codigos
{
    class _2235
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int z = int.Parse(vet[2]);

            int[] array = new int[] { x, y, z };
            int[] ordenaArray = array.OrderBy(n => n).ToArray();

            if (ordenaArray[0] == ordenaArray[1] || ordenaArray[1] == ordenaArray[2])
                Console.WriteLine("S");
            else if (ordenaArray[0] + ordenaArray[1] == ordenaArray[2])
                Console.WriteLine("S");
            else
                Console.WriteLine("N");
        }
    }
}
