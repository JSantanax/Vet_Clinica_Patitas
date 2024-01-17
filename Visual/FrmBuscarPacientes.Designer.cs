namespace Visual
{
    partial class FrmBuscarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarPacientes));
            this.txtIngresarMascota = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.ptbLupa = new System.Windows.Forms.PictureBox();
            this.PtbBuscarPaciente = new System.Windows.Forms.PictureBox();
            this.dtgvPacientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngresarMascota
            // 
            this.txtIngresarMascota.Location = new System.Drawing.Point(363, 117);
            this.txtIngresarMascota.Name = "txtIngresarMascota";
            this.txtIngresarMascota.Size = new System.Drawing.Size(230, 20);
            this.txtIngresarMascota.TabIndex = 0;
            this.txtIngresarMascota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblPaciente.Location = new System.Drawing.Point(373, 84);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(255, 18);
            this.lblPaciente.TabIndex = 9;
            this.lblPaciente.Text = "Ingrese el Nombre de la Mascota";
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaciente.Click += new System.EventHandler(this.lblPaciente_Click);
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnBuscarMascota.Location = new System.Drawing.Point(398, 147);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(92, 40);
            this.btnBuscarMascota.TabIndex = 11;
            this.btnBuscarMascota.Text = "buscarVeterinario";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // ptbLupa
            // 
            this.ptbLupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLupa.BackgroundImage")));
            this.ptbLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLupa.Location = new System.Drawing.Point(599, 115);
            this.ptbLupa.Name = "ptbLupa";
            this.ptbLupa.Size = new System.Drawing.Size(24, 22);
            this.ptbLupa.TabIndex = 12;
            this.ptbLupa.TabStop = false;
            this.ptbLupa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PtbBuscarPaciente
            // 
            this.PtbBuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtbBuscarPaciente.BackgroundImage")));
            this.PtbBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbBuscarPaciente.Location = new System.Drawing.Point(466, 12);
            this.PtbBuscarPaciente.Name = "PtbBuscarPaciente";
            this.PtbBuscarPaciente.Size = new System.Drawing.Size(65, 60);
            this.PtbBuscarPaciente.TabIndex = 10;
            this.PtbBuscarPaciente.TabStop = false;
            this.PtbBuscarPaciente.Click += new System.EventHandler(this.PtbBuscarPaciente_Click);
            // 
            // dtgvPacientes
            // 
            this.dtgvPacientes.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dtgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgvPacientes.Location = new System.Drawing.Point(12, 233);
            this.dtgvPacientes.Name = "dtgvPacientes";
            this.dtgvPacientes.Size = new System.Drawing.Size(943, 96);
            this.dtgvPacientes.TabIndex = 13;
            this.dtgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPacientes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del Dueño";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de Paciente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Especie";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Peso";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Esterilizado";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vacunado";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Telefono 1";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Telefono 2";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Dirección";
            this.Column11.Name = "Column11";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnBorrar.Location = new System.Drawing.Point(496, 147);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 40);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(960, 357);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dtgvPacientes);
            this.Controls.Add(this.ptbLupa);
            this.Controls.Add(this.btnBuscarMascota);
            this.Controls.Add(this.PtbBuscarPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtIngresarMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBuscarPacientes";
            this.Text = "buscarVeterinario Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuscarPacientes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBuscarPacientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmBuscarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresarMascota;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.PictureBox PtbBuscarPaciente;
        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.PictureBox ptbLupa;
        private System.Windows.Forms.DataGridView dtgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnBorrar;
    }
}