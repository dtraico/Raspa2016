using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Datos;





namespace Raspa2016
{
    public partial class FormPrincipal : Form
    {

        private static FormPrincipal inst;
        public static Usuarios User;
        public static int repartoImprimir1 = 0;
        
        public static FormPrincipal GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new FormPrincipal();
                return inst;
            }
        }  
      
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void FormPricipal_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel6.Text = DateTime.Now.ToLongDateString();// + " " + DateTime.Now.ToShortTimeString(); //ToShortTimeString();
        }

        private void FormPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //FormLogin frm = new FormLogin();
            //frm.Dispose();
            DialogResult respuesta = MessageBox.Show("Salir del Sistema?", "CERRAR GESTCONT ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Close();
        }
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       

        
        //#################################################################################

       
  

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin.GetForm.Text = "Cambio de Usuario";
            FormLogin.GetForm.ShowDialog();
            
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            FormLogin.GetForm.Text = "Cambio de Usuario";
            FormLogin.GetForm.ShowDialog();    
        }

     

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmpresa form= new formEmpresa();
            form.ShowDialog();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios form=new FormUsuarios();
            form.ShowDialog();
        
        }

 

        private void agregarNuevoPremioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPremios form = new FormPremios();
            form.ShowDialog();
        }

        private void generarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerarLote form = new FormGenerarLote();
            form.ShowDialog();
        }

        
      

       

      

      
     
      


        //#################################################################################
 
    }
}
