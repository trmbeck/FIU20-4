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


        }
    }
}
