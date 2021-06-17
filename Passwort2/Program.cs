using System;

namespace Passwort2
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            int zaehler = 1;
            bool wurdePeingegeben = false, wurdeReingegeben = false, wurdeOeingegeben = false, wurdeGeingegeben = false;
            int anzahl = 1;
            
            do
            {
                do
                {
                    Console.WriteLine($"bitte {zaehler}. Zeichen eingeben:");
                    eingabe = Console.ReadLine();

                    if (eingabe.ToUpper() == "P") wurdePeingegeben = true;
                    if (eingabe.ToUpper() == "R") wurdeReingegeben = true;
                    if (eingabe.ToUpper() == "O") wurdeOeingegeben = true;
                    if (eingabe.ToUpper() == "G") wurdeGeingegeben = true;
                    zaehler++;
                } while (zaehler <= 4);
                zaehler = 1;
                if (wurdePeingegeben && wurdeReingegeben && wurdeOeingegeben && wurdeGeingegeben)
                {
                    //passwort korrekt!!!
                    Console.WriteLine("korrekt");
                    break;
                }
                else
                {
                    Console.WriteLine("falsch");
                }
                anzahl++;
            } while (anzahl <= 3);
        }
    }
}
