using System;

namespace Treuepraemie
{
    class Program
    {
        static void Main(string[] args)
        {
            int jahre;
            int praemie;

            Console.WriteLine("Bitte Jahre angeben: ");
            jahre = Convert.ToInt32(Console.ReadLine());

            if (jahre < 3)
            {
                Console.WriteLine("keine Prämie");
            }
            else
            {
                if (jahre < 10)
                {
                    praemie = 150 * (jahre - 2);
                }
                else
                {
                    praemie = 150 * (jahre - 2);
                    praemie = praemie + 10 * (jahre - 9);
                }
                Console.WriteLine("Prämie: " + praemie);
            }

        }
    }
}
