using System;

namespace ForLoop4
{
    class Program
    {
        static void Main(string[] args)
        {
            int init = 10;
            int zeile;

            for (zeile = init; zeile >= 0; zeile = zeile - 1)
            {
                for (int spalte = zeile; spalte >= 0; spalte = spalte - 1)
                {
                    //Console.Write(i + ":" + j + " ");
                    Console.Write(spalte + " ");
                }
                Console.WriteLine();
                Console.Write(" ");
            }
        }
    }
}
