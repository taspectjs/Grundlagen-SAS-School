﻿using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        public static void Main()
        {
            eigabe(text);

            int anzahl = 0;
            anzahl = ausgabeTextMalX("das ist sehr schwer", 10);
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

        public static string eingabe(string text)
        {
            Console.WriteLine("Geben sie den Text ein der ausgegeben wird!");
            text = Console.ReadLine();

            return text;

        }
    }
}
