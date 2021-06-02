using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace einfacheDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfache Datentypen:"); // Snippet cw für Console.WriteLine();

            // 1 Byte - 8 Bit
            // Integer (Ganzzahl): 4 Bytes -> 32 Bit -> 2 hoch 32 -> ca. 4,3 Mrd.
            // negative Zahlen im int: -2,147 bis +2,147 Mrd.
            // Speicherung von negativen Zahlen im Zweierkomplement
            int ganzZahl1; //Deklaration einer Integer (Ganzahl) Variablen mit dem Bezeichner zahl1
            ganzZahl1 = 2000000000;//Initialisierung -> erstmals einen Wert zuweisen

            int ganzZahl2 = 2000000000; // Deklaration und Initialisierung in einer Anweisung
            ganzZahl2 = 2000000000;

            //Gleitkommazahl der Speichergröße 8 Bytes, Genauigkeit 15-16 Stellen
            double kommaZahl1 = 10.4;
            double kommaZahl2 = 1.56D;

            //Gleitkommazahl der Speichergröße 4 Bytes, Genauigkeit 7-8 Stellen
            float kommaZahl3 = 100000.12F; //F Literalsuffix für float
            float kommaZahl4 = 100000.05f; //f Literalsuffix für float

            long ganzZahlLong = 10000L; //L Literalsuffix für long


            //Dezimalzahl 16 Bytes, Genauigkeit von 28 Stellen
            decimal dezimalZahl1 = 10.5M; //M Literalsuffix für decimal

            Console.WriteLine("Genauigkeit von Float:");
            Console.WriteLine(kommaZahl4 + kommaZahl3);

            Console.Write("Min. Wert von int: ");
            Console.WriteLine(int.MinValue);
            Console.Write("Max. Wert von int: ");
            Console.WriteLine(int.MaxValue);

            Console.Write("Zahl1: ");
            Console.WriteLine(ganzZahl1);

            Console.Write("Zahl2: ");
            Console.WriteLine(ganzZahl2);

            Console.Write("Summe: ");
            Console.WriteLine(unchecked(ganzZahl2 + ganzZahl1)); // Berechnung des Ergebnisses und anschließender Ausgabe

            ganzZahl1 = 111; //Zuweisung -> Speicherung des Wertes im Arbeitsspeicher

            Console.Write("Summe: ");
            Console.WriteLine(checked(ganzZahl2 + ganzZahl1)); //Prüfung auf Overflow(Überlauf) mit entsprechender Fehlermeldung (Ausnahme)

            Console.Write(kommaZahl1);
            Console.Write(" + ");
            Console.Write(kommaZahl2);
            Console.Write(" = ");
            Console.WriteLine(kommaZahl1 + kommaZahl2);


            //Zeichenfolge
            string zeichenfolge = "Wie ist ihr Name?";
            string tasteDruecken = "Bitte Fasel-Taste drücken ...";
            string name;

            Console.WriteLine(zeichenfolge);
            name = Console.ReadLine();

            Console.Write("Hallo ");
            Console.WriteLine(name);

            Console.WriteLine("Bitte Ganzzahl 1 eingeben:");
            string eingabe1 = Console.ReadLine(); // "10"
            int zahl1 = int.Parse(eingabe1);

            Console.WriteLine("Bitte Ganzzahl 2 eingeben:");
            string eingabe2 = Console.ReadLine(); // "20"
            int zahl2 = int.Parse(eingabe2);

            Console.Write("Ergebnis ist: ");
            Console.Write(eingabe1); Console.Write(" + "); Console.Write(eingabe2); Console.Write(" = ");
            Console.WriteLine(eingabe1 + eingabe2); //Konkatenation, Verkettung zweier Zeichenfolgen:  "10" + "20"  -> "1020"    

            Console.Write("Ergebnis nach dem Parsen ist: ");
            //Console.Write(zahl1);Console.Write(" + "); Console.Write(zahl2);Console.Write(" = ");
            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + (zahl1+zahl2));

            //arithmetische Operatoren:
            // - Subtraktion
            // * Multiplikation
            // / Division
            // % Modulo: Ganzzahldivision mit Rest

            Console.WriteLine("Bitte Kommazahl 1 eingeben:");
            eingabe1 = Console.ReadLine(); // "10"
            double kzahl1 = double.Parse(eingabe1);

            Console.WriteLine("Bitte Kommazahl 2 eingeben:");
            eingabe2 = Console.ReadLine(); // "20"
            double kzahl2 = double.Parse(eingabe2);

            Console.WriteLine("Ergebnis: " + (kzahl1 + kzahl2));

            Console.Write(tasteDruecken);

            //Datentyp boolean Speicher: 1 Byte
            bool zustand = true;
            zustand = false;

            //Vergleichsoperatoren
            bool groesser = 10 > 5;
            bool kleiner = 5 < 10;
            bool kleinerGleich = 10 <= 10;
            bool groesserGleich = 10 >= 10;
            bool istGleich = zahl1 == zahl2;
            bool ungleich = zahl1 != zahl2;

            int alterDesUsers = 17;

            bool nochmalSpielen = false;
            do
            {
                //Auswahl des Spiels
                //Prüfung des Alters, wenn Spiel ab 18
                if (alterDesUsers >= 18)
                {
                    // User darf Spiel spielen
                    Console.WriteLine("User spielt");
                }
                else
                {
                    // User darf Spiel NICHT spielen
                    // Ausgabe zu jung
                    Console.WriteLine("User zu jung");
                }
                //highscore anzeigen
                //nochmal oder anderes spiel?
                Console.WriteLine("Nochmal?");
                if (Console.ReadLine()=="Ja")
                {
                    nochmalSpielen = true;
                }
                else
                {
                    nochmalSpielen = false;
                }
            } while (nochmalSpielen);


            Console.WriteLine(kleiner);
            /*
             Logische Operatoren

             UND-Verknüpfung
             A   &   B  |  C
            -----------------
             0       0  |  0
             0       1  |  0
             1       0  |  0
             1       1  |  1
             
             ODER-Verknüpfung
             A   |   B  |  C
            -----------------
             0       0  |  0
             0       1  |  1
             1       0  |  1
             1       1  |  1
             

            EXKLUSIV ODER-Verknüpfung
             A   ^   B  |  C
            -----------------
             0       0  |  0
             0       1  |  1
             1       0  |  1
             1       1  |  0
             

            NICHT-Verknüpfung
            A   !A
            ------
            0    1
            1    0

             */

            bool ergebnis = groesser ^ groesserGleich;

            bool ergebnisUmgekehrt = !ergebnis; //Invertierung

            int EXORresult = 14 ^ 7;

            /*
                0 0 0 0  1 1 1 0
                0 0 0 0  0 1 1 1 ^
                ----------------
                0 0 0 0  1 0 0 1
            */

            Console.ReadKey();
        }
    }
}
