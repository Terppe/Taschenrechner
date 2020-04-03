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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            string ersteZahlAlsString = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVomBenutzer();

            //Wandeln Text in Gleitkommazahlen
            // Auslagern in Methode, wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            view.GibResultatAus(operation);
            view.WarteAufEndeDurchbenutzer();
        }

        


    }
}
