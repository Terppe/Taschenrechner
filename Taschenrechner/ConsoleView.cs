using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{   class ConsoleView
    {
        private readonly RechnerModel _model;

        public ConsoleView(RechnerModel model)
        {
            this._model = model;
            BenutzerWillBeenden = false;
        }

        
        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            // TODO: Refactoring benötigt - Probleme: unübersichtlich, nicht DRY, nicht SLA!

            // Eingabe und Validierung der ersten Zahl
            do
            {
                _model.ErsteZahl = HoleZahlVomBenutzer();
                if (_model.AktuellerFehler == Fehler.GrenzwertUeberschreitung)
                {
                    Console.WriteLine("FEHLER: Zahl muss größer als {0} und kleiner als {1} sein.", RechnerModel.UntererGrenzwert, RechnerModel.ObererGrenzwert);
                }
            }
            while (_model.AktuellerFehler == Fehler.GrenzwertUeberschreitung);

            // Eingabe und Validierung des Operators
            _model.Operation = HoleOperatorVomBenutzer();

            // Eingabe und Validierung der zweiten Zahl
            do
            {
                _model.ZweiteZahl = HoleZahlVomBenutzer();
                if (_model.AktuellerFehler == Fehler.GrenzwertUeberschreitung)
                {
                    Console.WriteLine("FEHLER: Zahl muss größer als {0} und kleiner als {1} sein.", RechnerModel.UntererGrenzwert, RechnerModel.ObererGrenzwert);
                }
            }
            while (_model.AktuellerFehler == Fehler.GrenzwertUeberschreitung);
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe.ToUpper() == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                _model.ErsteZahl = _model.Resultat;
                _model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (Fertig zum Beenden): ");
            return Console.ReadLine();
        }
        private double HoleZahlVomBenutzer()
        {
            string eingabe;
            double zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            eingabe = Console.ReadLine();

            while (!double.TryParse(eingabe, out zahl))
            {
                Console.WriteLine("Du musst eine gültige Gleitkommatahl eingeben! ");
                Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: ,.- ");
                Console.WriteLine("Dabei muss das - als erstes Zeichen vor einer Ziffer gestzt werden.");
                Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen. ");
                Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen. ");
                Console.WriteLine("Alle drei Sonderzeichen sind optional! ");
                Console.WriteLine();
                Console.Write("Bitte gib erneut die Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
            }
            return zahl;
        }

        private string HoleOperatorVomBenutzer()
        {
            string operation;

            do
            {
                Console.Write("Bitte gib die auszuführende Operation ein (+, -, /, *): ");
                operation = Console.ReadLine();
                _model.Operation = operation;

                if (_model.AktuellerFehler == Fehler.UngueltigeOperation)
                {
                    Console.WriteLine("FEHLER: Die eingegebene Operation wird nicht unterstützt.");
                }
            }
            while (_model.AktuellerFehler == Fehler.UngueltigeOperation);

            return operation;
        }

        public void GibResultatAus()
        {

            switch (_model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: : {0}", _model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: : {0}", _model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Die Quotient ist: : {0}", _model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Die Produkt ist: : {0}", _model.Resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation gewählt !");
                    break;
            }
        }

    }
}
