using System;

namespace GPS_Daten
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dezimalMinute;
            int minuten, sekunden;


            do
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Bitte Dezimalminuten angeben: ");
                string eingabe = Console.ReadLine(); // Bsp: 21,62083
                dezimalMinute = Convert.ToDecimal(eingabe);

                minuten = (int)dezimalMinute; // 21
                sekunden = (int)((dezimalMinute - minuten) * 60);  // 21,62083 - 21 => 0,62083 -> mal 60 

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}' {1}\"", minuten, sekunden); // 21' 37"
            } while (dezimalMinute != 0);

        }
    }
}
