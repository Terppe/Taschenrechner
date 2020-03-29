using System;

// hier ein weiterer Kommentar

namespace Taschenrechner
{
    class Program
    {
        // METHODE DEFINIEREN (in 7 Schritten)
        // (optional) Modifizierer definieren
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Runde Klammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optional diese definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenrumpf schreiben)


        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            string ersterSummand = HoleSummanden("Bitte gib den ersten Summanden ein: ");
            string zweiterSummand = HoleSummanden("Bitte gib den zweiten Summanden ein: ");

            //Wandeln Text in Gleitkommazahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            //Ausgabe
            Console.WriteLine("Die Summe ist: : {0}" , summe);

            WarteAufBenutzerEingabe();
        }

        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden bitte RETURN drücken! ");

            Console.ReadLine();

        }
    }
}
