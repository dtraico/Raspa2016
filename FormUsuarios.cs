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

namespace Raspa2016
{
    public partial class FormUsuarios : Form
    {
        NUsuario reglaUsuario=new NUsuario();
        
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            
            listar();
            cmbTipo.SelectedIndex = 1;
        }

        private void listar()
        {
            try
            {

               
                dvgUsuarios.AutoGenerateColumns = false;
                dvgUsuarios.DataSource = reglaUsuario.Listar();
                foreach (DataGridViewRow fila in dvgUsuarios.Rows)
                {

                    fila.Cells[3].Value = "********";
                }

                toolStripStatusLabel1.Text = dvgUsuarios.RowCount + " Usuarios";
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//eliminar Usuario
        {
            if (dvgUsuarios.CurrentRow == null) return;
            try
            {
                var user = reglaUsuario.getDatos(int.Parse(dvgUsuarios.CurrentRow.Cells[0].Value.ToString()));
                    
                DialogResult res = MessageBox.Show("Seguro de Eliminar el Usuario: "+ user.pNombre, "Atencion!!!",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (FormPrincipal.User.idUsuario == user.pIdUsuario)
                    {
                        MessageBox.Show("No puede Eliminar el Usuario: " + user.pNombre +
                                        "\nMotivo: Es el Usuario Actual del Sistema", "Atencion...");
                        return;
                    }
                    reglaUsuario.Eliminar(user.pIdUsuario);
                    MessageBox.Show("Usuario Eliminado con Exito", "Usuario Eliminado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    listar();
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }//Salir

        private void toolStripButton1_Click(object sender, EventArgs e)//Agregar Usuario
        {
            toolStrip1.Enabled = false;
            dvgUsuarios.Enabled = false;
            this.Height = 480;
            txtNombre.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelar();
        }//Cancelar

        private void button1_Click(object sender, EventArgs e)
        {

           

            if (txtNombre.TextLength >= 3 && txtUsuario.TextLength >= 3)
            {
                if (txtPassword.Text.Equals(txtRepetirpass.Text))
                {

                    if (txtPassword.TextLength <= 3)
                    {
                        MessageBox.Show("El Password debe tener entre 4 y 8 Caracteres","INGRESAR USUARIO");
                        return;
                    }
                    
                    
                    EUsuario u = new EUsuario(cmbTipo.SelectedIndex + 1, txtUsuario.Text, txtPassword.Text,
                        txtNombre.Text);
                    bool a = reglaUsuario.insertar(u);
                    if (a)
                        MessageBox.Show("Usuario Ingresado con Exito", "Usuario Ingresado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    listar();
                    cancelar();
                }
                else
                {
                    MessageBox.Show("El Password no coincide, por favor Repitalo", "INGRESAR USUARIO");
                }

            }
            else
            {
                MessageBox.Show("El Nombre y el Usuario deben tener mas de 4 Caracteres", "INGRESAR USUARIO");
            }
        }//Guardar

        private void cancelar()
        {
            toolStrip1.Enabled = true;
            dvgUsuarios.Enabled = true;
            this.Height = 320;

            foreach (TextBox c in this.Controls.OfType<TextBox>())
            {
                c.Clear();
            }

        }
    }
}
