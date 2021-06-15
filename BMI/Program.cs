using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double l;
            double m;
            double bmi;

            Console.Write("Bitte Körpergröße in cm angeben: ");
            string eingabe = Console.ReadLine();
            l = Convert.ToDouble(eingabe);

            Console.Write("Bitte Gewicht in kg angeben: ");
            eingabe = Console.ReadLine();
            m = Convert.ToDouble(eingabe);

            //l = l / 100; // von cm nach m

            bmi = m / ((l / 100) * (l / 100));

            if (bmi < 18.5)
            {
                Console.WriteLine("Untergewicht");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Übergewicht");
            }
            else
            {
                Console.WriteLine("Normalgewicht");
            }


            Console.WriteLine("Bitte Taste drücken ...");
            Console.ReadKey();
        }
    }
}
