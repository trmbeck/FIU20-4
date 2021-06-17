using System;

namespace ForLoop3
{
    class Program
    {
        static void Main(string[] args)
        {
            int schrittweite = 1;
            int startwert = 1;
            int max;

            Console.WriteLine("Bitte Maxwert angeben: ");
            max = Convert.ToInt32(Console.ReadLine());

            for(int zaehler = startwert; zaehler > 0; zaehler = zaehler + schrittweite) //Definition
            {
                //Ausgabe zaehler
                if (schrittweite == -1 && zaehler == 1) 
                    Console.WriteLine(zaehler);
                else
                {
                    Console.Write("{0}, ",zaehler);      // letzte Komma könnte noch entfernt werden 
                }
                //zählrichtung umschalten
                if (zaehler == max) schrittweite = -1;

                //zaehler erhöhen/veringern
                // muss nicht, ist in der Schleifendefinition schon drin
            }
        }
    }
}
