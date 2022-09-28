//https://www.beecrowd.com.br/judge/pt/problems/view/1047
using System;

namespace desafiosURI.Codigos
{
    class URI_1047
    {
        static void Main(string[] args)
        {
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