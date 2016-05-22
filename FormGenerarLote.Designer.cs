namespace Raspa2016
{
    partial class FormGenerarLote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblMensaje_de_lote = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.lblDia = new System.Windows.Forms.Label();
            this.nudSemana = new System.Windows.Forms.NumericUpDown();
            this.lblSemana = new System.Windows.Forms.Label();
            this.dvPremio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPremio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(652, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1_1_201";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(547, 59);
            this.lblLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(103, 20);
            this.lblLote.TabIndex = 5;
            this.lblLote.Text = "N° de Lote: ";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMensaje_de_lote
            // 
            this.lblMensaje_de_lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje_de_lote.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMensaje_de_lote.Location = new System.Drawing.Point(8, 111);
            this.lblMensaje_de_lote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje_de_lote.Name = "lblMensaje_de_lote";
            this.lblMensaje_de_lote.Size = new System.Drawing.Size(753, 34);
            this.lblMensaje_de_lote.TabIndex = 0;
            this.lblMensaje_de_lote.Text = "Semana 1 - Dia 1:Martes Vigencia: 12/05/2016 al 18/05/2016";
            // 
            // nudDia
            // 
            this.nudDia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDia.Location = new System.Drawing.Point(416, 54);
            this.nudDia.Margin = new System.Windows.Forms.Padding(4);
            this.nudDia.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.ReadOnly = true;
            this.nudDia.Size = new System.Drawing.Size(49, 29);
            this.nudDia.TabIndex = 3;
            this.nudDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(283, 59);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(94, 20);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "N° de Día: ";
            // 
            // nudSemana
            // 
            this.nudSemana.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSemana.Location = new System.Drawing.Point(187, 54);
            this.nudSemana.Margin = new System.Windows.Forms.Padding(4);
            this.nudSemana.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSemana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSemana.Name = "nudSemana";
            this.nudSemana.ReadOnly = true;
            this.nudSemana.Size = new System.Drawing.Size(49, 29);
            this.nudSemana.TabIndex = 1;
            this.nudSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSemana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.Location = new System.Drawing.Point(8, 59);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(128, 20);
            this.lblSemana.TabIndex = 0;
            this.lblSemana.Text = "N° de Semana:";
            // 
            // dvPremio
            // 
            this.dvPremio.AllowUserToAddRows = false;
            this.dvPremio.AllowUserToDeleteRows = false;
            this.dvPremio.AllowUserToResizeColumns = false;
            this.dvPremio.AllowUserToResizeRows = false;
            this.dvPremio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvPremio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dvPremio.Location = new System.Drawing.Point(13, 174);
            this.dvPremio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvPremio.MultiSelect = false;
            this.dvPremio.Name = "dvPremio";
            this.dvPremio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvPremio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvPremio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPremio.Size = new System.Drawing.Size(447, 490);
            this.dvPremio.TabIndex = 7;
            this.dvPremio.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPremio_CellLeave);
            this.dvPremio.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvPremio_CellValueChanged);
            this.dvPremio.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvPremio_CurrentCellDirtyStateChanged);
            this.dvPremio.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dvPremio_EditingControlShowing);
            this.dvPremio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dvPremio_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMensaje_de_lote);
            this.groupBox1.Controls.Add(this.lblSemana);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.nudSemana);
            this.groupBox1.Controls.Add(this.lblLote);
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.nudDia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERAR LOTE DE IMPRESION DE CUPONES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(502, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(657, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 22);
            this.textBox2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormGenerarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvPremio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGenerarLote";
            this.Text = ".:. Raspa2016 -Generar Lote .:.";
            this.Load += new System.EventHandler(this.FormGenerarLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPremio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.NumericUpDown nudSemana;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblMensaje_de_lote;
        private System.Windows.Forms.DataGridView dvPremio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}