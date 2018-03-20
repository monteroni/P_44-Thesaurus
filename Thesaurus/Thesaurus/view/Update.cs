using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesaurus.view
{
    public partial class frmUpdate : Form
    {
        private Controller control;
        private string path;
        public frmUpdate(Controller control)
        {
            // Links Control & View
            this.control = control;
            

            // Prepares the UI
            InitializeComponent();
        }

        private void btnUpdateTemp_Click(object sender, EventArgs e)
        {
            path = txtbUpdateTemp.Text;
            control.UpdateTemp(path);
        }
    }
}
