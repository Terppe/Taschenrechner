﻿using System;

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
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte wähle die auszuführende Operation (+ - / *) aus: ");

            //Wandeln Text in Gleitkommazahlen
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            double resultat = 0;

            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe ist: : {0}", resultat);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Differenz ist: : {0}", resultat);
                    break;

                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Quotient ist: : {0}", resultat);
                    break;

                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Produkt ist: : {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation gewählt !");
                    break;
            }

            //Ausgabe
            HoleBenutzerEingabe("Zum Beenden bitte RETURN drücken! ");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }

        static double Addiere(double ersteZahlAlsString, double zweiteZahlAlsString)
        {
            double summe = ersteZahlAlsString + zweiteZahlAlsString;

            return summe;
        }

        static double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;

            return differenz;
        }
        static double Multipliziere(double multiplicator, double multiplicand)
        {
            double produkt = multiplicator * multiplicand;

            return produkt;
        }
        static double Dividiere(double dividend, double divisor)
        {
            double quotient = dividend / divisor;

            return quotient;
        }
    }
}
