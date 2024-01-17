namespace Visual
{
    partial class FrmAgendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendar));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.lblSx = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblVeterionario = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.pbxCP_02 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(210, 166);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Location = new System.Drawing.Point(90, 166);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(100, 30);
            this.btnAgenda.TabIndex = 5;
            this.btnAgenda.Text = "Agendar";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(86, 12);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(63, 14);
            this.lblPaciente.TabIndex = 7;
            this.lblPaciente.Text = "Paciente:";
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(329, 12);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 14);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSexo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(17, 124);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 14);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(80, 121);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(132, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Items.AddRange(new object[] {
            "Panchito",
            "Lentehita",
            "Copón de Nieve",
            "Gary",
            "Lavadito"});
            this.cmbPaciente.Location = new System.Drawing.Point(89, 41);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(153, 22);
            this.cmbPaciente.TabIndex = 10;
            this.cmbPaciente.Text = "Seleccione paciente:";
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(258, 12);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(42, 14);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEd.Location = new System.Drawing.Point(250, 44);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(47, 14);
            this.lblEd.TabIndex = 7;
            this.lblEd.Text = "__ años";
            this.lblEd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSx
            // 
            this.lblSx.AutoSize = true;
            this.lblSx.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSx.Location = new System.Drawing.Point(322, 44);
            this.lblSx.Name = "lblSx";
            this.lblSx.Size = new System.Drawing.Size(49, 14);
            this.lblSx.TabIndex = 7;
            this.lblSx.Text = "Hembra";
            this.lblSx.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(191, 13);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(32, 14);
            this.lblEspecie.TabIndex = 7;
            this.lblEspecie.Text = "Gato";
            this.lblEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEspecie.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVeterionario
            // 
            this.lblVeterionario.AutoSize = true;
            this.lblVeterionario.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterionario.Location = new System.Drawing.Point(17, 88);
            this.lblVeterionario.Name = "lblVeterionario";
            this.lblVeterionario.Size = new System.Drawing.Size(80, 14);
            this.lblVeterionario.TabIndex = 7;
            this.lblVeterionario.Text = "Veterinario:";
            this.lblVeterionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVeterionario.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Items.AddRange(new object[] {
            "Doc. Luis Fernando Abarca",
            "Doc. Maria Luisa Astudillo",
            "Doc. Freddy Miguel Suárez",
            "Doc. Verónica del Rocio Mendoza"});
            this.cmbDoctor.Location = new System.Drawing.Point(120, 86);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(264, 22);
            this.cmbDoctor.TabIndex = 10;
            this.cmbDoctor.Text = "Seleccione doctor:";
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(231, 124);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 14);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarFont = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.CustomFormat = "hh:mm tt";
            this.dtpHora.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(284, 121);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(0);
            this.dtpHora.MaxDate = new System.DateTime(2023, 11, 9, 20, 52, 36, 0);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(100, 20);
            this.dtpHora.TabIndex = 9;
            this.dtpHora.Value = new System.DateTime(2023, 11, 9, 18, 0, 0, 0);
            this.dtpHora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pbxCP_02
            // 
            this.pbxCP_02.BackgroundImage = global::Visual.Properties.Resources.CP_02;
            this.pbxCP_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCP_02.Location = new System.Drawing.Point(7, 5);
            this.pbxCP_02.Margin = new System.Windows.Forms.Padding(0);
            this.pbxCP_02.Name = "pbxCP_02";
            this.pbxCP_02.Size = new System.Drawing.Size(69, 69);
            this.pbxCP_02.TabIndex = 6;
            this.pbxCP_02.TabStop = false;
            // 
            // FrmAgendar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(398, 219);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSx);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblEd);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblVeterionario);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.pbxCP_02);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgendar";
            this.Text = "Agendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgendar_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.PictureBox pbxCP_02;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.Label lblSx;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblVeterionario;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}