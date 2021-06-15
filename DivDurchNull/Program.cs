using System;

namespace DivDurchNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division durch Null");

            double a = -10;
            double b = 0;
            double c;

            c = a / b;

            if (double.IsNegativeInfinity(c))
                Console.WriteLine("minus unendlich: " + c); // "minus unendlich"


            if (double.IsPositiveInfinity(c))
                Console.WriteLine("plus unendlich: " + c); // "plus unendlich"

            if (double.IsInfinity(c))
                Console.WriteLine("unendlich: " + c); // "unendlich"

            a = 0;
            c = a / b;

            if (double.IsNaN(c))
                Console.WriteLine("c is Not a Number: " + c); // NaN: Not a Number

            int d = -10;
            int e = 0;
            int f;

            f = d / e; // Error, Ausnahme: divided by zero
        }
    }
}
