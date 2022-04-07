using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        public static void Main()
        {

            int anzahl = 0;
            anzahl = ausgabeTextMalX("GSO = Georg Simon Ohm!", 10);
            Console.Write("Der Text wurd: {0} wiederholt! " + anzahl);
        }

        public static int ausgabeTextMalX(string text, int wiederholungen)
        {

            for (int i = 0; i < wiederholungen; i++)
            {
                Console.WriteLine(text);

            }
            return text.Length*wiederholungen;

        }
    }
}
