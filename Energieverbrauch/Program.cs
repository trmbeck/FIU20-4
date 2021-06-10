using System;

namespace Energieverbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Variablen
            int leistung = 100, stunden = 4, tage = 300; // die Werte nennt man Literale
            
            //Eingabe
            Console.Write("Leistung: ");
            string eingabe = Console.ReadLine();
            leistung = Convert.ToInt32(eingabe);

            Console.Write("Stunden: ");
            eingabe = Console.ReadLine();
            stunden = Convert.ToInt32(eingabe);

            Console.Write("Tage: ");
            eingabe = Console.ReadLine();
            tage = Convert.ToInt32(eingabe);

            int verbrauch;

            //Verarbeitung
            verbrauch = leistung * stunden * tage;

            //Ausgabe
            Console.WriteLine("Verbrauch: " + verbrauch + "Wh");

            //Obligatorisches Anhalten
            Console.WriteLine("bitte Taste drücken zum beenden ...");
            Console.ReadKey();
            //Console.ReadLine();
        }
    }
}
