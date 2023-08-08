using System;

namespace desafiosURI.Codigos
{
    public class _2003
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] parts = input.Split(':');
                int hours = int.Parse(parts[0]);
                int minutes = int.Parse(parts[1]);

                switch (hours)
                {
                    case (7): Console.WriteLine("Atraso maximo: " + minutes); break;
                    case (8): Console.WriteLine("Atraso maximo: " + (60 + minutes)); break;
                    case (9): Console.WriteLine("Atraso maximo: " + (120 + minutes)); break;
                    default: Console.WriteLine("Atraso maximo: 0"); break;
                }
            }
        }
    }
}
