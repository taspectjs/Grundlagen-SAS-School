using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geben sie den Schrittgröße ein: ");
            double schrittgröße = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben sie den Abstand ein: ");
            double abstand = Convert.ToDouble(Console.ReadLine());

            double p = 0.017, A = 0.068;
            double l = schrittgröße * abstand;
            double R = p * (l/ A);

            string abst = "Wiederabstand", meter = "Meter";
                
            Console.Write("\n{0,6}",meter); Console.Write("{0,17}\n",abst);
            Console.Write("{0,4:G}m", l); Console.Write("{0,15:G}hm",R);

            Console.ReadKey();
            























        }
    }
}
