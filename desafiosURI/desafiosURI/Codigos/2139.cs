//https://www.beecrowd.com.br/judge/pt/problems/view/2139
using System;

namespace desafiosURI.Codigos
{
    internal class _2139
    {
        static void Main(string[] args)
        {

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] data = input.Split(' ');
                int mes = int.Parse(data[0]);
                int dia = int.Parse(data[1]);

                DateTime natal = new DateTime(2016, 12, 25);
                DateTime dataAtual = new DateTime(2016, mes, dia);

                if (dataAtual == natal)
                    Console.WriteLine("E natal!");
                else if (dataAtual == natal.AddDays(-1))
                    Console.WriteLine("E vespera de natal!");
                else if (dataAtual > natal)
                    Console.WriteLine("Ja passou!");
                else
                {
                    TimeSpan diferenca = natal - dataAtual;
                    int diasFaltando = diferenca.Days;
                    Console.WriteLine("Faltam {0} dias para o natal!", diasFaltando);
                }
            }

        }
    }
}
