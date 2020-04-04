using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            Operation = "unbekannt";
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

        public int Test { get; set; }

        
    }
}
