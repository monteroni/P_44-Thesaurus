using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesaurus
{
        public partial class frmThesaurus : Form
        {

            private Controller control;
            /// <summary>
            /// Constructeur de la vue 
            /// </summary>
            public frmThesaurus(Controller control)
            {
                // Links Control & View
                this.control = control;
                control.View = this;

                // Prepares the UI
                InitializeComponent();
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            view.frmUpdate frmUp = new view.frmUpdate(control);
            frmUp.ShowDialog();
        }
    }
}
