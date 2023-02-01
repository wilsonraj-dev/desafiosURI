//https://www.beecrowd.com.br/judge/pt/problems/view/1043
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _1043
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(nums[0]);
            double B = Convert.ToDouble(nums[1]);
            double C = Convert.ToDouble(nums[2]);

            if ((A < B + C) && (B < A + C) && (C < A + B))
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
