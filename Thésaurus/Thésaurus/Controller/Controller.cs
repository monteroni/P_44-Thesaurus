using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thésaurus
{
    class Controller
    {
        // Pour accéder en L/E la vue et le modèle
        private Model _model;
        public Model Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private View _view;
        public View View
        {
            get { return _view; }
            set { _view = value; }
        }

        /// <summary>
        /// Consutructeur du controller
        /// </summary>
        public Controller()
        {
        }

    }
}
