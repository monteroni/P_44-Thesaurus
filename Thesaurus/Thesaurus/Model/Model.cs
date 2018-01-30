using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    public class Model
    {
        /// <summary>
        /// Constructeur du modèle qui initialise les données de l'application
        /// et assure la liaison entre le modèle et le contrôleur
        /// </summary>
        /// <param name="control"></param>
        public Model(Controller control)
        {
            control.Model = this;
        }
    }
}
