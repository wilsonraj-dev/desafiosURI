using System;

namespace desafiosURI.Codigos
{
    class URI_1046
    {
        static void Main(string[] args)
        {
            /* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
               sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora 
               e máxima de 24 horas.
               
               Entrada
               A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
               
               Saída
               Apresente a duração do jogo conforme exemplo abaixo. */
               
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
