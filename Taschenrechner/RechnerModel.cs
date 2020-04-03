using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
        }
        public void Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
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

    }
}
