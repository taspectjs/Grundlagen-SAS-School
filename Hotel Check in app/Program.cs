using System;

namespace Hotel_Check_in_app
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein!");
            string eingabe_str = Console.ReadLine();
            short eingabe_short;

            bool flag = short.TryParse(eingabe_str, out eingabe_short);

          )
            {

          
            
        }

        static void DATAGet()
        {
            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] Vorname = { "John", "Paul", "George", "Ringo" };
            string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] Übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82, 48, 329.48, 989.52, 247.38 };
        }

    }
}
