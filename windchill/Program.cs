using System;

namespace windchill
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperatur, geschwindigkeit;
            double WCT;

            Console.Write("Temperatur in °C: ");
            string eingabe = Console.ReadLine();
            temperatur = Convert.ToSingle(eingabe);

            Console.Write("Geschwindigkeit in km/h: ");
            eingabe = Console.ReadLine();
            geschwindigkeit = Convert.ToSingle(eingabe);

            WCT = 13.12 + 0.6215 * temperatur - 11.37 * Math.Pow(geschwindigkeit, 0.16)
                    + 0.3965 * temperatur * System.Math.Pow(geschwindigkeit, 0.16);

            Console.WriteLine("gefühlte Temperatur: {0:f1}°C", WCT);

            Console.ReadKey();
        }
    }
}
