using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{   class ConsoleView
    {
        private RechnerModel _model;

        public ConsoleView(RechnerModel model)
        {
            this._model = model;
        }

        public string HoleZahlVomBenutzer()
        {
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            return Console.ReadLine();
        }

        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, *, /): ");
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchbenutzer()
        {
            Console.Write("Zum Beenden bitte RETURN drücken! ");
            Console.ReadLine();
        }

        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            return Console.ReadLine(); ;
        }

        public void GibResultatAus(string operation)
        {

            switch (operation)
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
