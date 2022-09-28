//https://www.beecrowd.com.br/judge/pt/problems/view/1046
using System;

namespace desafiosURI.Codigos
{
    class URI_1046
    {
        static void Main(string[] args)
        {
           string[] horarios = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(horarios[0]);
            int horaFinal = int.Parse(horarios[1]);
            int tempoTotal = 0;

            if (horaInicial > horaFinal)
            {
                tempoTotal = 24 - (horaInicial - horaFinal);
                Console.WriteLine($"O JOGO DUROU {tempoTotal} HORA(S)");
            }
            else if (horaFinal > horaInicial)
            {
                tempoTotal = horaFinal - horaInicial;
                Console.WriteLine($"O JOGO DUROU {tempoTotal} HORA(S)");
            }
            else if (horaInicial == horaFinal)
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
    }
}