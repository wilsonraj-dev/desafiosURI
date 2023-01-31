using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI.Codigos
{
    class _2386
    {
        static void Main(string[] args)
        {
            int telescopeoArea = int.Parse(Console.ReadLine());
            int numEstrelas = int.Parse(Console.ReadLine());
            int estrelasVisiveis = 0;

            for (int i = 0; i < numEstrelas; i++)
            {
                int fotons = int.Parse(Console.ReadLine());

                if (fotons * telescopeoArea >= 40000000)
                {
                    estrelasVisiveis++;
                }
            }

            Console.WriteLine(estrelasVisiveis);
        }
    }
}
