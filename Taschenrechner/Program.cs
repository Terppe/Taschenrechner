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
            ConsoleView view = new ConsoleView();

                string ersteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string operation = view.HoleBenutzerEingabe("Bitte wähle die auszuführende Operation (+ - / *) aus: ");

            //Wandeln Text in Gleitkommazahlen
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            GibResultatAus(model.Resultat, operation);
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


    }
}
