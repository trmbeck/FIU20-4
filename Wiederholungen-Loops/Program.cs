using System;

namespace Wiederholungen_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string eingabe = "ja";

            //Vergleichsoperatoren
            //---------------------
            // == ist gleich
            // != ungleich
            // < kleiner
            // > größer
            // <= kleiner oder gleich 
            // >= größer oder gleich 

            Console.WriteLine("kopfgesteuerte Schleife");
            while (eingabe != "nein")
            {
                Console.WriteLine("wiederholen?");
                eingabe = Console.ReadLine();
                if (eingabe == "bla")
                    Console.WriteLine("blubb");
                if (eingabe == "42")
                    Console.WriteLine("Die Antwort auf alle Fragen");
            }
            Console.WriteLine("kopfgesteuerte Schleife beendet!");



            Console.WriteLine("\n\n\nfussgesteuerte Schleife");
            do
            {
                Console.WriteLine("Loop Code");
                Console.WriteLine("nochmal?");
                eingabe = Console.ReadLine();
            } while (eingabe == "ja");
            Console.WriteLine("fussgesteuerte Schleife beendet!");

            // Escape - Sequenzen --> Steuerungsmöglichkeit \n new line

            Console.WriteLine("\n------------------\n\nzählergesteuerte Schleife");
            int startwert = Convert.ToInt32(Console.ReadLine());
            int endwert = Convert.ToInt32(Console.ReadLine());

            for(int index = startwert;index <= endwert;index = index + 1)
            {
                Console.WriteLine("Durchgang: " + index);
            }

            Console.WriteLine("zählergesteuerte Schleife beendet!");
        }
    }
}
