using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{   class ConsoleView
    {
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            return Console.ReadLine(); ;
        }

        public static void GibResultatAus(double resultat, string operation)
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

    }
}
