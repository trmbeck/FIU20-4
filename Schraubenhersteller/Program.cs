using System;

namespace Schraubenhersteller
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestellmenge;
            double rabatt = 0.05;
            double versandgebuehr = 5.00;
            double preisProSchraube = 0.20;
            double Gesamtpreis;

            Console.Write("Bitte Schraubenmenge angeben: ");
            string eingabe = Console.ReadLine();
            bestellmenge = Convert.ToInt32(eingabe);

            if (bestellmenge < 1000)
            {
                //wahr, true
                Gesamtpreis = (bestellmenge * preisProSchraube) + versandgebuehr;
            }
            else
            {
                //falsch, false
                Gesamtpreis = (bestellmenge * preisProSchraube) - (bestellmenge * preisProSchraube * rabatt);
            }

            Console.WriteLine($"Der Gesamtpreis beträgt {Gesamtpreis:f2} Euro");



            Console.WriteLine("Bitte Taste drücken ...");
            Console.ReadKey();
        }
    }
}
