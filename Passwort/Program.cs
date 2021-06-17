using System;

namespace Passwort
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\tPasswort 2.0\n"); char Zeichen1;
            char Zeichen2;

            char Zeichen3;

            char Zeichen4;

            char antwort = 'j';

            bool istok = false;

            int i = 1;

            do
            {
                Console.Write("\n\tEingabe Zeichen 1:  ");
                Zeichen1 = Convert.ToChar(Console.ReadLine());
                Zeichen1 = char.ToUpper(Zeichen1);

                Console.Write("\n\tEingabe Zeichen 2:  ");
                Zeichen2 = Convert.ToChar(Console.ReadLine());
                Zeichen2 = char.ToUpper(Zeichen2); Console.Write("\n\tEingabe Zeichen 3:  ");

                Zeichen3 = Convert.ToChar(Console.ReadLine());
                Zeichen3 = char.ToUpper(Zeichen3);
                Console.Write("\n\tEingabe Zeichen 4:  ");

                Zeichen4 = Convert.ToChar(Console.ReadLine());
                Zeichen4 = char.ToUpper(Zeichen4);

                // ORFP

                if (Zeichen1 == 'P' || Zeichen2 == 'P' || Zeichen3 == 'P' || Zeichen4 == 'P')
                {
                    if (Zeichen1 == 'R' || Zeichen2 == 'R' || Zeichen3 == 'R' || Zeichen4 == 'R')
                    {
                        if (Zeichen1 == 'O' || Zeichen2 == 'O' || Zeichen3 == 'O' || Zeichen4 == 'O')
                        {
                            if (Zeichen1 == 'G' || Zeichen2 == 'G' || Zeichen3 == 'G' || Zeichen4 == 'G')
                            {
                                istok = true;
                            }
                        }
                    }
                }

                if (istok == false)
                {
                    Console.Write("\n\n\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();

                    Console.WriteLine("\n\n");

                    Console.WriteLine("\nErneute Eingabe? [j/n]");

                    antwort = Convert.ToChar(Console.ReadLine());

                    antwort = char.ToUpper(antwort);
                }
                i++;

            } while (istok == false && i <= 3 && antwort == 'J');

            if (istok == false)
            {
                Console.Write("\n\n\t\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login nicht korrekt!");

                Console.ResetColor();

                Console.WriteLine("\n\n\tZum beenden Taste drücken....");

            }
            if (istok == true)
                Console.BackgroundColor = ConsoleColor.Green;

            if (istok == true) Console.WriteLine("\n\n\tLogin korrekt!\n\n\tZum beenden Taste drücken....");
            Console.ReadKey();

        }


    }
}

