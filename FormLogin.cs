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
    public partial class FormLogin : Form
    {
        private static FormLogin inst;
        NUsuario reglaUsuario = new NUsuario();
        EUsuario eu = new EUsuario();

        public static FormLogin  GetForm{
            get{
                if (inst == null || inst.IsDisposed)
                    inst = new FormLogin();
                    return inst;
                 }
            }  
       
        
        
        
        public FormLogin()
        {
            InitializeComponent();
        }

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            Usuarios u;
            
            String user = txtUsuario.Text;
            String pass = txtPass.Text;

            if (reglaUsuario.IsvalidUser(user, pass) != null)
            {
                u = reglaUsuario.IsvalidUser(user, pass);


                if (u.tipoUsuario == 1)
                {
                    FormPrincipal.GetForm.configuracionToolStripMenuItem1.Visible = true;

                }
                else
                {
                    FormPrincipal.GetForm.configuracionToolStripMenuItem1.Visible = false;
                }
                FormPrincipal.GetForm.toolStripStatusLabel4.Text = u.nombreUsuario;
                FormPrincipal.User = u;
                FormPrincipal.GetForm.Show();
                FormPrincipal.GetForm.Focus();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña no Coinciden");
               
                txtPass.Text="";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
            txtPass.Text="";
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }

        


        
    }
}
