using System;

namespace Durchschnitt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Durchschnitt");
            string eingabe;
            double summe = 0;
            double produkt = 1;
            int anzahl = 0;

            for (int zaehler = 1;zaehler <= 5;zaehler++) // 5 Zahlen abfragen, ++ -> zaehler++ ==> zaehler = zaehler + 1
            {
                Console.WriteLine("Bitte {0}. Zahl eingeben: ",zaehler);
                eingabe = Console.ReadLine();
                if (eingabe.ToUpper() == "A")
                {
                    // Code zum Beenden
                    anzahl = zaehler - 1;
                    //zaehler = 5;
                    break;
                }
                else
                {
                    double eingegebeneZahl = Convert.ToDouble(eingabe);
                    
                    summe = summe + eingegebeneZahl;
                    produkt = produkt * eingegebeneZahl;
                    
                    anzahl = zaehler;
                }
            }

            double durchschnitt = summe / anzahl;
            Console.WriteLine("Summe: {0}",summe);
            Console.WriteLine("Produkt: {0}", produkt);
            Console.WriteLine("Anzahl: {0}", anzahl);
            Console.WriteLine("Durchschnitt: {0:f2}",durchschnitt);

            // Bsp. durchschnitt: 3,3666666666
            double gerundeterDurchschnitt = Math.Round(durchschnitt,2); // 3,3666666666 ==> 3,37
        }
    }
}
