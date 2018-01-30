using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thésaurus
{
    public partial class View : Form
    {

        private Controller control;
        /// <summary>
        /// Constructeur de la vue 
        /// </summary>
        public View(Controller control)
        {
            // Links Control & View
            this.control = control;
            control.View = this;

            // Prepares the UI
            InitializeComponent();
        }
    }
}
