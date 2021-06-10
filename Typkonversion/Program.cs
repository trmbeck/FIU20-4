using System;

namespace Typkonversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int ganzzahl;
            double gleitkommazahl; //15-stellig

            ganzzahl = 10;
            gleitkommazahl = 1.5;

            // speichern des Integers in Double -> funktioniert (Konversion implizit, implizites Casting)
            gleitkommazahl = ganzzahl; // kein Verlust der Genauigkeit --> 10.0

            gleitkommazahl = 1.99;
            ganzzahl = (int)gleitkommazahl; // Konversion explizit, explizites Casting (Zieldatentyp)Quelldatentyp


            decimal d = (decimal)gleitkommazahl;
            float f = (float)gleitkommazahl; //8-stellig

            gleitkommazahl = f;


            //Beispiel: runden eines Wertes auf 2 Stellen

            double wert = 10.456;

            double dezimalwert = wert - (int)wert; // Aufgabe: GPS-Daten

            int ganzzahlwert = (int)((wert+0.005)*100); // --> (int)1046,1 --> 1046
            wert = ganzzahlwert / 100.0; // 10.46
            
            Console.WriteLine(wert);

            //Alternativ
            Console.WriteLine(Math.Round(10.456, 2));

            Console.WriteLine(ganzzahl);
        }
    }
}
