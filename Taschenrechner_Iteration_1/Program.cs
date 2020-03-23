using System;

// hier ein weiterer Kommentar

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen

            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Wandeln Text in Gleitkommazahlen
            float ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            //Berechnung ausführen
            float summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Die Summe ist: : {0}" , summe);
            Console.ReadLine();
        }
    }
}
