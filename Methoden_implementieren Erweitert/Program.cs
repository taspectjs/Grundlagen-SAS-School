using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Welchen text möchtest du ausgeben?");
            string ein = Console.ReadLine();

            Console.WriteLine("Wie oft soll der text wiederholt werden?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            
            anzahl = ausgabeTextMalX("{0}", 200);
            Console.Write("Der Text wurd: {0} wiederholt! " + anzahl);
        }

        public static int ausgabeTextMalX(string text, int wiederholungen)
        {

            for (int i = 0; i < wiederholungen; i++)
            {
                Console.WriteLine(text);

            }
            return text.Length;

        }
    }
}
