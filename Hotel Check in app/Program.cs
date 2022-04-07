using System;

namespace Hotel_Check_in_app
{
    class Program
    {
        static void Main()
        {
            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] Vorname = { "John", "Paul", "George", "Ringo" };
            string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
            short[] Übernachtung = { 1, 4, 12, 3 };
            double[] rechnungsbetrag = { 82, 48, 329.48, 989.52, 247.38 };

            Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein!");
            string eingabe_str = Console.ReadLine();
            short eingabe_short;

            bool flag = short.TryParse(eingabe_str, out eingabe_short);

            if (flag)
            {
                var Data = GetData(eingabe_short ,zimmernummer, Vorname, Nachname, Übernachtung, rechnungsbetrag);
                if (Data.Item1)
                {
                    Console.WriteLine("Kunden Daten:\n Zimmernummer: {0}\n Vorname: {1}\n Nachname: {2}\n Übernachtungstage: {3}\n Rechnungsbetrag: {4}",Data.Item2, Data.Item3, Data.Item4, Data.Item5, Data.Item6);
                }
                else
                {
                    Console.WriteLine("Error, Die Einegeben Zimmer Nummer wurde im System nicht gefunden!");
                    
                }
            }
            else
            {
                var Data = GetData(eingabe_str, zimmernummer, Vorname, Nachname, Übernachtung, rechnungsbetrag);
                if (Data.Item1)
                {
                    Console.WriteLine("Kunden Daten:\n Zimmernummer: {0}\n Vorname: {1}\n Nachname: {2}\n Übernachtungstage: {3}\n Rechnungsbetrag: {4}",Data.Item2, Data.Item3, Data.Item4, Data.Item5, Data.Item6);
                }
                else
                {
                    Console.WriteLine("Error, Der Eingegeben Nachname wurde im System nicht gefunden!");
                }
            }

            Console.ReadKey();
  
        }

        static (bool,short,string,string,short,double) GetData(string value, short[]zimmernummer,string[]Vorname,string[]Nachname,short[]Übernachtung,double[]rechnungsbetrag)
        {

           for(int i = 0;i<Nachname.Length;i++)
            { 
                if (value == Nachname[i])
                {
                    return (true, zimmernummer[i],Vorname[i],Nachname[i],Übernachtung[i],rechnungsbetrag[i]);
                    
                }

            }
            return (false, -1,string.Empty,string.Empty,-1,-1);


        }
        static (bool, short, string, string, short, double) GetData(short value, short[] zimmernummer, string[] Vorname, string[] Nachname, short[] Übernachtung, double[] rechnungsbetrag)
        {

            for (int i = 0; i < zimmernummer.Length; i++)
            {
                if (value == zimmernummer[i])
                {
                    return (true, zimmernummer[i], Vorname[i], Nachname[i], Übernachtung[i], rechnungsbetrag[i]);

                }

            }
            return (false, -1, string.Empty, string.Empty, -1, -1);




        }

    }
}
