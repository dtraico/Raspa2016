using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raspa2016
{
    public partial class FrmSlpash : Form
    {
        public FrmSlpash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
