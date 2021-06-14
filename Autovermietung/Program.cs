using System;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            double mwstSatz = 0.19;
            double zuschlag = 0.65;
            double normaltarif = 68;
            double kilometerFrei = 200;
            double nettobetrag;
            double kilometer;
            double mwstBetrag;

            Console.Write("gefahrene Kilometer: ");
            string eingabe = Console.ReadLine();
            kilometer = Convert.ToDouble(eingabe);

            if (kilometer > 200)
            {
                //Aufschlag
                nettobetrag = normaltarif + (kilometer - kilometerFrei) * zuschlag;
            }else
            {
                //Normaltarif
                nettobetrag = normaltarif;
            }

            mwstBetrag = nettobetrag * mwstSatz;


            Console.WriteLine("Rechnungsbetrag: {0:f2}",nettobetrag + mwstBetrag);
            Console.WriteLine("enthaltene MwSt: {0:f2}",mwstBetrag);

            Console.WriteLine("Bitte Taste drücken ...");
            Console.ReadKey();
        }
    }
}
