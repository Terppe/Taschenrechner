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
         
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte wähle die auszuführende Operation (+ - / *) aus: ");

            //Wandeln Text in Gleitkommazahlen
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            double resultat = Berechnung(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            GibResultatAus(resultat, operation);
            HoleBenutzerEingabe("Zum Beenden bitte RETURN drücken! ");
        }

        private static void GibResultatAus(double resultat, string operation)
        {

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: : {0}", resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: : {0}", resultat);
                    break;

                case "/":
                    Console.WriteLine("Die Quotient ist: : {0}", resultat);
                    break;

                case "*":
                    Console.WriteLine("Die Produkt ist: : {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation gewählt !");
                    break;
            }
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }

        static double Berechnung(double ersteZahl, double zweiteZahl, string operation)
        {
            double resultat = 0;

            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;

                default:
                    resultat = 0;
                    break;
            }

            return resultat;

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
    
        static double Multipliziere(double multiplikator, double multiplikand)
        {
            return multiplikator * multiplikand;
        }
    
        static double Dividiere(double dividend, double divisor)
        {
            return dividend / divisor;
        }

    }
}
