//https://www.beecrowd.com.br/judge/pt/problems/view/1134
using System;

namespace desafiosURI.Codigos
{
    class URI_1134
    {
        static void Main(string[] args)
        {
            int N = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                switch (N = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        alcool++; break;
                    case 2:
                        gasolina++; break;
                    case 3:
                        diesel++; break;
                    case 4:
                        exibirMenu = false; break;
                    default:
                        break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}