namespace Visual
{
    partial class FrmRevisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevisar));
            this.lblCitasAgendadas = new System.Windows.Forms.Label();
            this.ptbRevisarCitas = new System.Windows.Forms.PictureBox();
            this.dtgvCitasAgendadas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaAgendado = new System.Windows.Forms.Button();
            this.cmbPacienteAgendado = new System.Windows.Forms.ComboBox();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRevisarCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitasAgendadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCitasAgendadas
            // 
            this.lblCitasAgendadas.AutoSize = true;
            this.lblCitasAgendadas.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblCitasAgendadas.Location = new System.Drawing.Point(183, 82);
            this.lblCitasAgendadas.Name = "lblCitasAgendadas";
            this.lblCitasAgendadas.Size = new System.Drawing.Size(135, 18);
            this.lblCitasAgendadas.TabIndex = 8;
            this.lblCitasAgendadas.Text = "Citas Agendadas";
            this.lblCitasAgendadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCitasAgendadas.Click += new System.EventHandler(this.lblPaciente_Click);
            // 
            // ptbRevisarCitas
            // 
            this.ptbRevisarCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbRevisarCitas.BackgroundImage")));
            this.ptbRevisarCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbRevisarCitas.Location = new System.Drawing.Point(216, 12);
            this.ptbRevisarCitas.Name = "ptbRevisarCitas";
            this.ptbRevisarCitas.Size = new System.Drawing.Size(65, 60);
            this.ptbRevisarCitas.TabIndex = 0;
            this.ptbRevisarCitas.TabStop = false;
            this.ptbRevisarCitas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtgvCitasAgendadas
            // 
            this.dtgvCitasAgendadas.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dtgvCitasAgendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCitasAgendadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvCitasAgendadas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgvCitasAgendadas.Location = new System.Drawing.Point(27, 191);
            this.dtgvCitasAgendadas.Name = "dtgvCitasAgendadas";
            this.dtgvCitasAgendadas.Size = new System.Drawing.Size(438, 74);
            this.dtgvCitasAgendadas.TabIndex = 17;
            this.dtgvCitasAgendadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Especie:";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Veterinario Designado:";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha:";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora:";
            this.Column4.Name = "Column4";
            // 
            // btnConsultaAgendado
            // 
            this.btnConsultaAgendado.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnConsultaAgendado.Location = new System.Drawing.Point(322, 136);
            this.btnConsultaAgendado.Name = "btnConsultaAgendado";
            this.btnConsultaAgendado.Size = new System.Drawing.Size(83, 31);
            this.btnConsultaAgendado.TabIndex = 18;
            this.btnConsultaAgendado.Text = "Consultar";
            this.btnConsultaAgendado.UseVisualStyleBackColor = true;
            // 
            // cmbPacienteAgendado
            // 
            this.cmbPacienteAgendado.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacienteAgendado.FormattingEnabled = true;
            this.cmbPacienteAgendado.Items.AddRange(new object[] {
            "Panchito",
            "Lentehita",
            "Copón de Nieve",
            "Gary",
            "Lavadito"});
            this.cmbPacienteAgendado.Location = new System.Drawing.Point(165, 142);
            this.cmbPacienteAgendado.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPacienteAgendado.Name = "cmbPacienteAgendado";
            this.cmbPacienteAgendado.Size = new System.Drawing.Size(153, 22);
            this.cmbPacienteAgendado.TabIndex = 19;
            this.cmbPacienteAgendado.Text = "Seleccione paciente:";
            this.cmbPacienteAgendado.SelectedIndexChanged += new System.EventHandler(this.cmbPacienteAgendado_SelectedIndexChanged);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnEliminarCita.Location = new System.Drawing.Point(216, 283);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(83, 31);
            this.btnEliminarCita.TabIndex = 20;
            this.btnEliminarCita.Text = "Eliminar ";
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // FrmRevisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(492, 347);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.cmbPacienteAgendado);
            this.Controls.Add(this.btnConsultaAgendado);
            this.Controls.Add(this.dtgvCitasAgendadas);
            this.Controls.Add(this.lblCitasAgendadas);
            this.Controls.Add(this.ptbRevisarCitas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRevisar";
            this.Text = "Revisar Citas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRevisar_FormClosing);
            this.Load += new System.EventHandler(this.FrmRevisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRevisarCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitasAgendadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbRevisarCitas;
        private System.Windows.Forms.Label lblCitasAgendadas;
        private System.Windows.Forms.DataGridView dtgvCitasAgendadas;
        private System.Windows.Forms.Button btnConsultaAgendado;
        private System.Windows.Forms.ComboBox cmbPacienteAgendado;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}