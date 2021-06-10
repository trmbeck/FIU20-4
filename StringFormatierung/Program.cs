using System;

namespace StringFormatierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jahr         Population
            // 2021            1000000
            // 2020             800000
            // {index,Alignment:Formatierung}

            Console.WriteLine("{0,-5} {1,10}", "Jahr","Population");
            Console.WriteLine("{0,-5} {1,10}", 2021, 100000);
            Console.WriteLine("{0,-5} {1,10}", 2020, 800000);
            Console.WriteLine("{0,-5} {1,10}", 2019, 700000);
            Console.WriteLine("{0,-5} {1,10:f3}", 2000, 80000);

            Console.WriteLine();

            // Temperatur:
            Console.WriteLine("Temperatur: {0:##.00}", 27.53626);
            Console.WriteLine("Temperatur: {0:##.00}", 10.2);

            //Hex
            Console.WriteLine("Hexadezimal: {1,2}{0,18:x}", 3645326784,"0x");
            Console.WriteLine("Hexadezimal: {1,2}{0,18:X}", 3645326784,"0x");

            //float
            Console.WriteLine("Kommazahl:   {0,20:f4}", 1.1234567,23,"asdf");

            //Prozent
            Console.WriteLine("Prozent:     {0,20:p1}", 0.34);

            //Währung
            Console.WriteLine("Währung:     {0,20:c3}", 12.45);

            //Wissenschaftlich
            Console.WriteLine("wissensch.:  {0,20:e4}", 482384923588);


            string zeichenfolge = String.Format("Hallo {0}","Welt");


            Console.ReadKey();
        }
    }
}
