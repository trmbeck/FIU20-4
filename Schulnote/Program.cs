using System;

namespace Schulnote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note: ");
            int note = Convert.ToInt32(Console.ReadLine());

            #region mehrstufige Auswahl
            Console.Write("Schulnote in Text über mehrstufige Auswahl: ");
            if (note == 1)
            {
                Console.WriteLine("sehr gut");
            }else if (note == 2)
            {
                Console.WriteLine("gut");
            }else if (note == 3)
            {
                Console.WriteLine("befriedigend");
            }else if (note == 4)
            {
                Console.WriteLine("ausreichend");
            }
            else if (note == 5)
            {
                Console.WriteLine("mangelhaft");
            }
            else if (note == 6)
            {
                Console.WriteLine("ungenügend");
            }else
            {
                Console.WriteLine("Falsche Eingabe");
            }
            #endregion

            // mehrseitige Auswahl -> kein PAP-Symbol!!
            Console.Write("Schulnote in Text über mehrseitige Auswahl: ");
            switch (note) //Entscheider ist die Variable note mit deren Wert
            {
                case 1:
                    Console.WriteLine("sehr gut");
                    break;
                case 2:
                    Console.WriteLine("gut");
                    break;
                case 3:
                    Console.WriteLine("befriedigend");
                    break;
                case 4:
                    Console.WriteLine("ausreichend");
                    break;
                case 5:
                    Console.WriteLine("mangelhaft");
                    break;
                case 6:
                    Console.WriteLine("ungenügend");
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }

            string eingabe = Console.ReadLine();
            switch (eingabe)
            {
                case "Hallo":
                    Console.WriteLine("Welt");
                    break;
                case "Hans":
                    Console.WriteLine("im Glück");
                    break;
            }


            Console.WriteLine("\n\nEnde!!!");
        }
    }
}
