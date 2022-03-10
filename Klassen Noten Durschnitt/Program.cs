using System;

namespace Panjutorials
{
    class Programm
    {

        public static void Main(string[] args)
        {
            string eingabe = "0";
            int anzahl = 0;
            int gesamtwert = 0;
            int aktuelleZahl = 0;

            while (eingabe != "-1")
            {

                Console.WriteLine("Letzte Zahl war " + aktuelleZahl);
                Console.WriteLine("Bitte geben Sie die nächste Note ein.");
                Console.WriteLine("Bisherige Eingaben: " + anzahl);
                Console.WriteLine("Geben Sie -1 ein um den Durchschnitt zu berechnen");

                eingabe = Console.ReadLine();
                if (eingabe == "ende")
                {
                    Console.WriteLine("---------------------------------");
                    double durchschnitt = (double)gesamtwert / (double)anzahl;
                    Console.WriteLine("Der Durchschnitt ist " + durchschnitt);
                    Console.ReadKey();
                }

                if (Int32.TryParse(eingabe, out aktuelleZahl) && aktuelleZahl > 0 && aktuelleZahl < 7)
                {
                    gesamtwert = gesamtwert + aktuelleZahl;
                }
                else
                {
                    if (!(eingabe == "-1"))
                    {
                        Console.WriteLine("Bitte geben sie ganzzahlige Werte zwischen 1 und 6 ein!\n");
                        Console.ReadKey();
                    }

                    continue;
                }


                anzahl++;



            }


            Console.ReadLine();
        }


    }

}