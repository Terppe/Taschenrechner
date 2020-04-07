using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public enum Fehler
    {
        Keiner,
        GrenzwertUeberschreitung,
        UngueltigeOperation
    }

    public class RechnerModel
    {
        public static double ObererGrenzwert => 100.0;
        public static double UntererGrenzwert => -10.0;

        public double Resultat { get; private set; }
        private string _operation = "ungueltig";
        public string Operation
        {
            get => _operation;

            set
            {
                // Wir ändern den Wert der Eigenschaft nur, wenn ein anderer Wert
                // zugewiesen wird
                if (value != _operation)
                {
                    switch (value)
                    {
                        case "+":
                        case "-":
                        case "/":
                        case "*":
                            // Es wurde eine gültige Operation übergeben. Daher können wir
                            // den Fehler zurücksetzen ...
                            if (AktuellerFehler == Fehler.UngueltigeOperation)
                            {
                                AktuellerFehler = Fehler.Keiner;
                            }
                            // ... und den neuen Operator verwenden
                            _operation = value;
                            break;

                        default:
                            // Die übergebene Operation wird nicht unterstützt. Daher wird 
                            // angezeigt, dass ein Fehler anliegt und auch die operation zeigt
                            // an, dass etwas nicht stimmt.
                            _operation = "ungueltig";
                            AktuellerFehler = Fehler.UngueltigeOperation;
                            break;
                    }
                }
            }
        }

        private double _ersteZahl = 0;
        public double ErsteZahl
        {
            get => _ersteZahl;
            set
            {
                if (_ersteZahl != value)
                {
                    AktuellerFehler = GrenzwertCheck(value);
                    _ersteZahl = value;
                }
            }
        }

        private double _zweiteZahl = 0;
        public double ZweiteZahl
        {
            get => _zweiteZahl;
            set
            {
                if (_zweiteZahl != value)
                {
                    AktuellerFehler = GrenzwertCheck(value);
                    _zweiteZahl = value;
                }
            }
        }
        public Fehler AktuellerFehler { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
            AktuellerFehler = Fehler.Keiner;
        }

        public void Berechne()
        {
            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

                default:
                    Resultat = 0;
                    break;
            }
        }             



private Fehler GrenzwertCheck(double zahl)
        {
            Fehler resultat = Fehler.Keiner;

            if ((zahl < UntererGrenzwert) || (zahl > ObererGrenzwert))
            {
                resultat = Fehler.GrenzwertUeberschreitung;
            }

            return resultat;
        }

        private double Addiere(double ersteZahlAlsString, double zweiteZahlAlsString)
        {
            double summe = ersteZahlAlsString + zweiteZahlAlsString;

            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahend)
        {
            double differenz = minuend - subtrahend;

            return differenz;
        }

        private double Multipliziere(double multiplikator, double multiplikand)
        {
            return multiplikator * multiplikand;
        }

        private double Dividiere(double dividend, double divisor)
        {
            return dividend / divisor;
        }

    }
}
