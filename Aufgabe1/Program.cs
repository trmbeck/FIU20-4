using System;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int punktzahl;            
            do
            {
                Console.WriteLine("Bitte Punktzahl eingeben:");
                string eingabe = Console.ReadLine();
                punktzahl = Convert.ToInt32(eingabe);
                punktzahl = int.Parse(eingabe);

                if (punktzahl > 10 || punktzahl < 0)
                {
                    Console.WriteLine("ungültige Punktzahl!!!");
                }
                else
                {
                    if (punktzahl < 7)
                    {
                        Console.WriteLine("Nicht bestanden!!!");
                    }
                    else
                    {
                        Console.WriteLine("bestanden!!!");
                    }
                }
            } while (punktzahl != -1);
        }
    }
}
