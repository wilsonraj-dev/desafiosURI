using System;

namespace desafiosURI.Codigos
{
    class URI_1134
    {
        static void Main(string[] args)
        {
            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
               Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 
               2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) 
               deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando 
               o código informado for o número 4.
               
               Entrada
               A entrada contém apenas valores inteiros e positivos.
               
               Saída
               Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada 
               tipo de combustível, conforme exemplo. */

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
