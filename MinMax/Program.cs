using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min Max");
            int eingabeZahl;
            int min = 0;
            int max = 0;
            int anzahl = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Min: " + min);
                Console.WriteLine($"Max: {max}");
                Console.WriteLine("Anzahl: {0}", anzahl);
                Console.WriteLine("Zahl eingeben: ");
                eingabeZahl = Convert.ToInt32(Console.ReadLine());

                if (eingabeZahl > 0)
                {
                    anzahl++; // ==> anzahl = anzahl + 1; anzahl-- ==> anzahl = anzahl - 1
                    if (anzahl == 1)
                    {
                        max = eingabeZahl;
                        min = eingabeZahl;
                    }
                    else
                    {
                        if (eingabeZahl > max) max = eingabeZahl;
                        if (eingabeZahl < min) min = eingabeZahl;
                    }
                }

            } while (eingabeZahl != 0);

        }
    }
}
