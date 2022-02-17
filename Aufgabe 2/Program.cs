using System;

namespace UebungKA2
{
	class Aufgabe1
	{
		static void Main()
		{
			Console.WriteLine("´Bitte geben Sie die Anzahl der Durchläufe an");
			int durchlauf = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= durchlauf; i++)
			{
				Console.WriteLine("Durchlauf: {0,10}", i);
			}

			Console.WriteLine("-----------------------------\n");


			for (int kk = 4; kk >= -4; kk = kk - 2)
			{
				Console.WriteLine(kk);
			}

			Console.WriteLine("\n-----------------------------");

			for (short zaehler = 50; zaehler <= 100; zaehler -= -10)
			{
				Console.WriteLine(zaehler);
			}

			Console.WriteLine("-----------------------------");

			double zahl = 0;
			do
			{
				Console.WriteLine(zahl);
				zahl = zahl + 1.5;
			} while (zahl < 6);

			Console.ReadKey();
		}
	}
}