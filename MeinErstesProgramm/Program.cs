/* mehrzeilige
 * Kommentare
 * einfügen
 */
using System;

namespace MeinErstesProgramm
{
    /// <summary>
    /// Mein erstes Programm in C# :-), Startklasse
    /// </summary>
    class Program //Programmklasse
    {
        /// <summary>
        /// Das ist die Einstiegsmethode
        /// </summary>
        /// <param name="args">Argumente, die in der Kommandozeile übergeben werden</param>
        static void Main(string[] args) // Einstiegmethode
        {

            System.Console.WriteLine("Hello World!");  //Anweisung (statement): Ausgabe von "Hello World"         

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}