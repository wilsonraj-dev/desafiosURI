using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosURI.Codigos
{
    class URI_1047
    {
        static void Main(string[] args)
        {
            /* Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
               
               Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
               
               Entrada
               Quatro números inteiros representando a hora de início e fim do jogo.
               
               Saída
               Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” . */

            string[] dados = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(dados[0]);
            int minutoInicial = int.Parse(dados[1]);
            int horaFinal = int.Parse(dados[2]);
            int minutoFinal = int.Parse(dados[3]);

            horaInicial *= 60;
            horaFinal *= 60;
            int somaHoraInicialEMimInicial = horaInicial + minutoInicial;
            int somaHoraFimEMinFinal = horaFinal + minutoFinal;
            int subtraiTempoTotal = somaHoraFimEMinFinal - somaHoraInicialEMimInicial;
            int novaHora = 0;
            int novoMinuto = 0;

            if (somaHoraFimEMinFinal <= somaHoraInicialEMimInicial)
            {
                subtraiTempoTotal += (24 * 60);
                novaHora = (int)subtraiTempoTotal / 60;
                novoMinuto = subtraiTempoTotal % 60;
                Console.WriteLine($"O JOGO DUROU {novaHora} HORA(S) E {novoMinuto} MINUTO(S)");
            }
            else
            {
                novaHora = (int)subtraiTempoTotal / 60;
                novoMinuto = subtraiTempoTotal % 60;
                Console.WriteLine($"O JOGO DUROU {novaHora} HORA(S) E {novoMinuto} MINUTO(S)");
            }
        }
    }
}
