using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Datos;
using Negocio;
using Entidades;


namespace Raspa2016
{
    public partial class FormEditarPremio : Form
    {
        public bool nuevo;//bandera para saber si es nuevo
        public int codNuevo;
        EPremios b = new EPremios();
        NPremio reglaPremio =new NPremio();

        public FormEditarPremio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
             try
            {
                 b.pIdPremio = Int16.Parse(txtIdBarrio.Text);
                 b.pDescripcion = txtDescripcion.Text;
               

                if (nuevo)
                {
                    
                    txtIdBarrio.Text = reglaPremio.Insertar(b).ToString();
                    MessageBox.Show("El registro se Inserto correctamente","Correcto!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    nuevo = false;//ponemos en false la bandera de insertar
                    codNuevo = Convert.ToInt32(txtIdBarrio.Text);
                    this.DialogResult = DialogResult.OK;
                    FormPremios.nom = b.pDescripcion;
                    Close();

                }
                else
                {
                    
                    reglaPremio.Editar(b);
                    MessageBox.Show("El registro se Edito correctamente", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPremios.nom = b.pDescripcion;
                    Close();
                }
            }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el formulario\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void FormEditarBarrio_Load(object sender, EventArgs e)
        {
            this.txtDescripcion.Focus();
            
        }

        //private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        //{
        //    Match m = Regex.Match(txtDescripcion.Text, @"^[a-zA-Z''-'\s]{3}$");
            
        //    if (!m.Success )
        //    {
        //        errorProvider1.SetError(txtDescripcion, "Por favor entre el nombre");
        //        txtDescripcion.BackColor = Color.SeaShell;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtDescripcion, "");
        //        txtDescripcion.BackColor = Color.White;
        //    }

        //}

     
    }
}
