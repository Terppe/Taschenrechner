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

        public void HoleEingabenVomBenutzer()
        { }

        
        public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            _model.ErsteZahl = HoleZahlVomBenutzer();
            _model.Operation = HoleOperatorVomBenutzer();
            _model.ZweiteZahl = HoleZahlVomBenutzer();

        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe == "Fertig")
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
            string zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();
            return Convert.ToDouble(zahl);
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum beenden bitte Return drücken!");
            Console.ReadLine();
        }
        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, *, /): ");
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchbenutzer()
        {
            Console.Write("Zum Beenden bitte RETURN drücken! ");
            Console.ReadLine();
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
