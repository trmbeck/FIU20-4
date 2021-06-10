using System;

namespace Zinsrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal zinsen, zinssatz, startkapital;

            Console.Write("Startkapital: ");
            string eingabe = Console.ReadLine();
            startkapital = Convert.ToDecimal(eingabe);

            Console.Write("Zinssatz: ");
            eingabe = Console.ReadLine();
            zinssatz = Convert.ToDecimal(eingabe);

            zinsen = startkapital * (zinssatz / 100);


            //Platzhalter in einem String mittels {index} --> z. B. {0}
            Console.WriteLine("Sie erhalten {0} Euro Zinsen für ein Jahr bei einem Startkapital von {1} Euro.",zinsen,startkapital);
            Console.WriteLine($"Sie erhalten {zinsen} Euro Zinsen für ein Jahr bei einem Startkapital von {startkapital} Euro.");

            //Obligatorisch
            Console.WriteLine("Taste drücken ...");
            Console.ReadKey();
        }
    }
}
