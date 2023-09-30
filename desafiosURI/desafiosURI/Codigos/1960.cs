//https://www.beecrowd.com.br/judge/pt/problems/view/1960
using System;

namespace desafiosURI.Codigos
{
    class _1960
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 0 || number >= 1000)
            {
                throw new ArgumentOutOfRangeException("O número deve estar entre 1 e 999.");
            }

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            int thousandsDigit = number / 1000;
            int hundredsDigit = (number % 1000) / 100;
            int tensDigit = (number % 100) / 10;
            int onesDigit = number % 10;
            Console.WriteLine(thousands[thousandsDigit] + hundreds[hundredsDigit] + tens[tensDigit] + ones[onesDigit]);
        }
    }
}
