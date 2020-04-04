using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private readonly ConsoleView _view;
        private readonly RechnerModel _model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this._view = view;
            this._model = model;
        }

        public void Ausführen()
        {
            _view.HoleEingabenFuerErsteBerechnungVomBenutzer();
            _model.Berechne();
            _view.GibResultatAus();
            _view.HoleEingabenFuerFortlaufendeBerechnung();

            while (!_view.BenutzerWillBeenden)
            {
                _model.Berechne();
                _view.GibResultatAus();
                _view.HoleEingabenFuerFortlaufendeBerechnung();
            }
        }
    }
}
