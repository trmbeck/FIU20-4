using System;

namespace Quartale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monat: ");
            string eingabe = Console.ReadLine();
            eingabe = eingabe.ToLower();

            goto MeineSprungmarke;

            if (eingabe == "januar" || eingabe == "februar" || eingabe == "märz" 
               // || eingabe == "Januar" || eingabe == "Februar" || eingabe == "März"
               // || eingabe == "JANUAR" || eingabe == "FEBRUAR" || eingabe == "FEBRUAR"
                )
                Console.WriteLine("Q1");
            else if (eingabe == "april" || eingabe == "mai" || eingabe == "juni")
                Console.WriteLine("Q2");
            else if (eingabe == "juli" || eingabe == "august" || eingabe == "september")
                Console.WriteLine("Q3");
            else if (eingabe == "oktober" || eingabe == "november" || eingabe == "dezember")
                Console.WriteLine("Q4");
            else Console.WriteLine("falsche Bezeichnung eingegeben");

            MeineSprungmarke:

            switch (eingabe)
            {
                case "januar":
                case "februar":
                case "märz":
                    Console.WriteLine("Q1");
                    break;
                case "april":
                case "mai":
                case "juni":
                    Console.WriteLine("Q2");
                    break;
                case "juli":
                case "august":
                case "september":
                    Console.WriteLine("Q3");
                    break;
                case "oktober":
                case "november":
                case "dezember":
                    Console.WriteLine("Q4");
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }
    }
}
