//https://www.beecrowd.com.br/judge/pt/problems/view/2815
using System;

namespace desafiosURI.Codigos
{
    internal class _2815
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            string[] textoArray = texto.Split(' ');
            string textoCorrigido = "";

            for (int i = 0; i < textoArray.Length; i++)
            {
                string palavra = textoArray[i];

                if (palavra.Length >= 4)
                {
                    if (palavra.Substring(0, 2) == palavra.Substring(2, 2))
                    {
                        palavra = palavra.Substring(2, palavra.Length - 2);
                    }
                }

                if (i == 0)
                    textoCorrigido += palavra;
                else
                    textoCorrigido += " " + palavra;
            }

            Console.WriteLine(textoCorrigido);
        }
    }
}
