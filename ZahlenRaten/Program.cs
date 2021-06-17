using System;

namespace ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen raten");

            int eingegebeneZahl;
            int zufallszahl;
            int anzahl = 1;

            Random Zufall = new Random((int)DateTime.Now.Ticks);
            zufallszahl = Zufall.Next(1, 101);
            do
            {
                Console.WriteLine("Zahl eingeben (Versuch {0})", anzahl);
                eingegebeneZahl = Convert.ToInt32(Console.ReadLine());
                anzahl++;

                if (eingegebeneZahl == zufallszahl)
                {
                    //Volltreffer
                    Console.WriteLine("Glückwunsch!!!");
                    break;
                }
                else
                {
                    if (eingegebeneZahl > zufallszahl)
                    {
                        //größer als zufallszahl
                        Console.WriteLine("Die gesuchte Zahl ist kleiner");
                    }
                    else
                    {
                        //kleiner als zufallszahl
                        Console.WriteLine("Die gesuchte Zahl ist größer");
                    }
                }
            } while (true);

        }
    }
}
