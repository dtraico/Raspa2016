using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Negocio;



namespace Raspa2016
{
    public partial class FormPremios : Form
    {
        NPremio reglaPremio = new NPremio();
        public static string nom;
        
        public FormPremios()
        {
            InitializeComponent();
        }

        private void FormPremios_Load(object sender, EventArgs e)
        {
            Lista("");
            txtBuscar.Focus();
        }
       
        private void Lista(String busca)
        {
            try
            {
                dvBarrio.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                dvBarrio.DataSource = reglaPremio.Listar(busca);
                dvBarrio.Columns[0].HeaderText = "Codigo";
                dvBarrio.Columns[0].Width = 90;
                dvBarrio.Columns[1].HeaderText = "Nombre";
                dvBarrio.Columns[1].Width = 320;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

            }

        }//llena la grilla con premios

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormEditarPremio frm = new FormEditarPremio();
            frm.nuevo = true;
            frm.ShowDialog();
            Lista(nom);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvBarrio.CurrentRow != null)
            {
                try
                {
                   DialogResult res = MessageBox.Show("Seguro de Editar el registro?", "Atencion!!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No) return;
                    FormEditarPremio frm = new FormEditarPremio();
                    var t = reglaPremio.getDatos(Int16.Parse(dvBarrio.CurrentRow.Cells[0].Value.ToString()));
                    frm.txtIdBarrio.Text = t.idPremio.ToString();
                    frm.txtDescripcion.Text = t.leyenda;

                    frm.ShowDialog();
                    Lista(nom);
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)//eliminar registro
        {
            if (dvBarrio.CurrentRow != null)
            {
                try
                {
                    DialogResult res = MessageBox.Show("Seguro de Eliminar el registro?", "Atencion!!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                     
                        reglaPremio.Eliminar(Int16.Parse(dvBarrio.CurrentRow.Cells[0].Value.ToString()));
                        Lista("  ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Lista(txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar;
            keyChar = e.KeyChar;

            if (!Char.IsLetter(keyChar) && keyChar != 8 && keyChar != 13 && keyChar != 32 && !Char.IsDigit(keyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13) //(char)Keys.Enter) 
            {
                Lista(txtBuscar.Text);
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //FormReporteBarrios form= new FormReporteBarrios();
            //form.ShowDialog();
        }

       


    }
}
