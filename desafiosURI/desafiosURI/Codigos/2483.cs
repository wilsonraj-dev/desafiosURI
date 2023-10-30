//https://www.beecrowd.com.br/judge/pt/problems/view/2483
using System;

namespace desafiosURI.Codigos
{
    internal class _2483
    {
        static void Main()
        {
            int I = int.Parse(Console.ReadLine());
            string felizNatal = "Feliz natal!!";
            string felizNatalConvertido = "";

            for (int i = 0; i < felizNatal.Length; i++)
            {
                if (i == 9)
                {
                    felizNatalConvertido += new string('a', I);
                }
                else if (i != 12)
                {
                    felizNatalConvertido += felizNatal[i];
                }
            }

            Console.WriteLine(felizNatalConvertido);
        }
    }
}
