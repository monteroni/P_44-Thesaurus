﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesaurus
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Les fondamentaux MVC (créations et liens entre eux) 
            Controller control = new Controller();
            Model model = new Model(control);
            frmThesaurus view = new frmThesaurus(control);

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(view);

        }
    }
}
