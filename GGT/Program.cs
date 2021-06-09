using System;

namespace GGT
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal = "j";
            do
            {
                // Abfrage erster Wert
                Console.WriteLine("Bitte geben sie den Wert für a ein: ");
                string eingabe = Console.ReadLine(); // Eingabe von Tastatur wird in "eingabe" gespeichert
                int a = int.Parse(eingabe); // int.Parse() analysiert "eingabe" auf Ganzzahl und gibt diese zurück


                //Abfrage zweiter Wert
                Console.WriteLine("Bitte geben sie den Wert für b ein:");
                eingabe = Console.ReadLine();
                int b = Convert.ToInt32(eingabe); // Konvertierung von einer Zeichenfolge in eine Ganzzahl

                while (a > 0 && b > 0) //kopfgesteuerte Schleife: solange a und b größer 0 sind
                {
                    //zweiseitige Auswahl
                    if (a > b) a = a - b;
                    else b = b - a;
                }

                Console.Write("Größter gemeinsamer Teiler ist: ");

                if (b == 0) Console.WriteLine(a); // Wenn b gleich 0 ist, dann steht in a der GGT
                else Console.WriteLine(b); // ansonsten steht der GGT in b

                Console.WriteLine("Nochmal?");
                nochmal = Console.ReadLine();

            } while (nochmal == "j");



            //Escape-Sequenzen
            Console.WriteLine("In einer Windowsanwendung wird eine neue Zeile über Escape-Sequenzen mittels \r\n");
            Console.WriteLine("\nEnde\t\tbitte Taste drücken"); // \n neue Zeile in Konsole \t Tabulatorsprung

            // Text --> "Hallo "C#""
            // Dateipfad: c:\temp\bla\global\random.txt
            // UNC-Pfad -> \\servername\freigabename\

            string begruessung = "Hallo \"C#\"";
            string dateipfad = "c:\\temp\\bla\\global\\random.txt";
            string uncpfad = "\\\\servername\\freigabename\\";

            //Verbatim String --> @-Zeichen vor Zeichenfolge
            //keine Escape-Sequenzen mehr
            string dateipfad2 = @"c:\temp\bla\global\random.txt";
            string uncpfad2 = @"\\server\freigabe\";

            Console.ReadKey();
        }
    }
}
