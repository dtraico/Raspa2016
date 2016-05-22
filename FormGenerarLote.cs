using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Raspa2016
{
    public partial class FormGenerarLote : Form
    {
        private NPremio reglaPremio = new NPremio();
        private NCupon reglaCupon= new NCupon();

        private string mensaSemana;
        private string mensajeDia;

        public FormGenerarLote()
        {
            InitializeComponent();
        }

        private void nudDia_ValueChanged(object sender, EventArgs e)
        {
            lblMensaje_de_lote.Text = "Semana 1 - Dia 1:Martes Vigencia desde 12/05/2016 al 18/05/2016";
        }

        private void FormGenerarLote_Load(object sender, EventArgs e)
        {
            llenaGrillaPremios();
        }

        private void llenaGrillaPremios()
        {
            try
            {
                dvPremio.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                dvPremio.DataSource = reglaPremio.listarPremios();

                var dataGridViewColumn = dvPremio.Columns["Premios"];
                if (dataGridViewColumn != null) dataGridViewColumn.HeaderText = "Nombre Premio";
                var gridViewColumn = dvPremio.Columns["Premios"];
                if (gridViewColumn != null) gridViewColumn.Width = 250;
                var viewColumn = dvPremio.Columns["idpremio"];
                if (viewColumn != null) viewColumn.Visible = false;


                var checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "checkBoxColumn";
                dvPremio.Columns.Insert(0, checkBoxColumn);


                var textBoxColumn = new DataGridViewTextBoxColumn();
                textBoxColumn.HeaderText = "Cantidad";
                textBoxColumn.Width = 60;
                textBoxColumn.Name = "textBoxColumn";
                dvPremio.Columns.Insert(1, textBoxColumn);

                dvPremio.Columns[0].ReadOnly = false;
                dvPremio.Columns[1].ReadOnly = true;
                dvPremio.Columns[2].ReadOnly = true;
                dvPremio.Columns[3].ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = string.Empty;
            foreach (DataGridViewRow row in dvPremio.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    message += Environment.NewLine;
                    message += row.Cells[1].Value.ToString() + " " + row.Cells[3].Value.ToString();
                }
            }

            MessageBox.Show("Selected Values" + message);
        }

        private void dvPremio_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) //header grilla
                return;
            if (e.ColumnIndex != 0) //columna checkbox
                return;

            if (dvPremio.Columns[e.ColumnIndex].Name == "checkBoxColumn")
            {
                DataGridViewRow row = dvPremio.Rows[e.RowIndex]; // Se toma la fila seleccionada
                DataGridViewCheckBoxCell checkBoxColumn = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                    // Se selecciona la celda del checkbox

                if (Convert.ToBoolean(checkBoxColumn.Value))
                {
                    row.Cells["textBoxColumn"].ReadOnly = false;
                    dvPremio.EditMode = DataGridViewEditMode.EditOnEnter;
                    if (dvPremio.CurrentRow != null) dvPremio.CurrentCell = dvPremio.CurrentRow.Cells[1];
                }
                else
                {
                    row.Cells["textBoxColumn"].Value = "";
                    row.Cells["textBoxColumn"].ReadOnly = true;

                }
            }

            dvPremio.EditMode = DataGridViewEditMode.EditOnF2;
        }

        private void dvPremio_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dvPremio.IsCurrentCellDirty)
            {
                dvPremio.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dvPremio_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dvPremio.CurrentCell.ColumnIndex == 1)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dvPremio_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dvPremio_KeyPress);
                }
            }
        }

        private void dvPremio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dvPremio.CurrentCell.ColumnIndex == 1)
            {
                if (e.KeyChar == (char) Keys.Back || char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
                    
            }
        }

        private void dvPremio_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dvPremio.CurrentCell.ColumnIndex == 1 && 
            if (dvPremio.CurrentCell.ColumnIndex == 1 && Convert.ToBoolean(dvPremio.CurrentRow.Cells[0].Value) == true)
            {
                if (dvPremio.CurrentCell.Value == null || dvPremio.CurrentCell.Value.ToString()=="")
                {
                    dvPremio.CurrentRow.Cells[0].Value = false;
                }
                    
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabla;

            DataTable tabla1 = new DataTable();

            var semana = 1;
            var dia = 1;
            var fInicio = Convert.ToDateTime("12/01/2016");
            var fVto = Convert.ToDateTime("12/01/2016");
            var estadoImpresion = false;
            var estadoCupon = false;
            var lote = 1234;
            foreach (DataGridViewRow row in dvPremio.Rows)
            {
                tabla = new DataTable();
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    var cant = Convert.ToInt32(row.Cells[1].Value.ToString());
                    var leyenda = Convert.ToInt32(row.Cells[2].Value.ToString());

                    tabla = reglaCupon.Listacupones(cant, leyenda, semana, dia, fInicio, fVto,
                            estadoImpresion, estadoCupon, lote);

                }
                tabla1.Merge(tabla);
            }
            
            if (tabla1.Rows.Count > 0)
            {
                MessageBox.Show("ok " + tabla1.Rows.Count);
            }
        }

     

       
    }
    //*********************************************************************//

    #region codigo suelto



    #endregion
}

