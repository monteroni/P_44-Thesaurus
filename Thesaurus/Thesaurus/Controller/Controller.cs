using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    public class Controller
    {
        // Pour accéder en L/E la vue et le modèle
        private Model _model;
        public Model Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private frmThesaurus _view;
        public frmThesaurus View
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

        public void UpdateTemp(string path)
        {
            try
            {
                Process.Start("Test K Google.exe", path + " file");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught.", e);
            }
            
        }
        public void UpdateWeb(string url)
        {
            try
            {
                Process.Start("Test K Google.exe", url + " web");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught.", e);
            }
            
        }
    }
}
