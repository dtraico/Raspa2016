using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Raspa2016
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmSlpash sp = new FrmSlpash();
            if (sp.ShowDialog() == DialogResult.OK)
            {
               //Application.Run(new FormLogin());
                Application.Run(new FormGenerarLote());

            }
        }
    }
}
