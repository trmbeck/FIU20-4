using System;

namespace ForLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            int startwert;

            Console.WriteLine("Eingabe: ");
            eingabe = Convert.ToInt32(Console.ReadLine());


            for(startwert = 1; startwert <= eingabe; startwert = startwert + 1)
            {
                if (startwert == eingabe)
                {
                    Console.Write(startwert);
                }
                else
                {
                    Console.Write(startwert + ", ");
                }
            }

        }
    }
}
