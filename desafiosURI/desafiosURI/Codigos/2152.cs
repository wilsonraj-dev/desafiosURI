//https://www.beecrowd.com.br/judge/pt/problems/view/2152
using System;
using System.Globalization;

namespace desafiosURI.Codigos
{
    class _2152
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string zeroEsquerda = "0";

            for (int i = 0; i < n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                int H = int.Parse(v[0]);
                int M = int.Parse(v[1]);
                int O = int.Parse(v[2]);

                DateTime eventTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, H, M, 0);
                string eventDescription = (O == 1) ? "A porta abriu!" : "A porta fechou!";
                Console.WriteLine(eventTime.ToString("HH:mm", CultureInfo.InvariantCulture) + " - " + eventDescription);
            }

        }
    }
}
