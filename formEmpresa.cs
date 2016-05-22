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
using System.IO;
using System.Xml.Serialization;

namespace Raspa2016
{
    public partial class formEmpresa : Form
    {
        public formEmpresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa emp = new Empresa();
                emp.pNombre = txtNombre.Text;
                emp.pCalle = txtCalle.Text;
                emp.pAltura = txtNumero.Text;
                emp.pBarrio = txtBarrio.Text;
                emp.pTelefono = txtTelefono.Text;
                emp.pMovil = txtCelular.Text;

                NEmpresa.grabarDatos(emp, @"C:\Tesis\GestCont\GestCont\empresa.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formEmpresa_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Tesis\GestCont\GestCont\empresa.xml"))
            {
                XmlSerializer xs= new XmlSerializer(typeof(Empresa));
                FileStream read = new FileStream(@"C:\Tesis\GestCont\GestCont\empresa.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

                Empresa emp = (Empresa) xs.Deserialize(read);
                txtNombre.Text=emp.pNombre;
                txtCalle.Text=emp.pCalle ;
                txtNumero.Text=emp.pAltura;
                txtBarrio.Text=emp.pBarrio;
                txtTelefono.Text=emp.pTelefono;
                txtCelular.Text=emp.pMovil;

                read.Close();

            }
        }

     

    }
}
