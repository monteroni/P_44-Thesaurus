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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateWeb_Click(object sender, EventArgs e)
        {
            if(txtbUpdateWeb.Text == "")
            {
                MessageBox.Show("Veuillez insérer un url");
            }
            else
            {
                string url = txtbUpdateWeb.Text;
                MessageBox.Show(url);
                control.UpdateWeb(url);
            }
            
        }
    }
}
