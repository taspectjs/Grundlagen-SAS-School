using System;

namespace Alterskontrolle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie ihr Alter ein");
            int alter = Convert.ToInt32(Console.ReadLine());

            while (alter <= 0 || alter > 120)
            {
                Console.WriteLine("Fehler... Geben Sie ihr Alter erneut ein!!");
                alter = Convert.ToInt32(Console.ReadLine());
            }

            if (alter < 18)
            {
                Console.WriteLine("Download wird verweigert");
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine("Spiel wird heruntergeladen...");
            }
            Console.ReadLine();
        }
    }
}