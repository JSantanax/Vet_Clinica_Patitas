namespace Visual
{
    partial class FrmPacienteNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacienteNuevo));
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.gboxTipo = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.rbtnPerro = new System.Windows.Forms.RadioButton();
            this.rbtnGato = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAmo = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblAmo = new System.Windows.Forms.Label();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSenas = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblEsteril = new System.Windows.Forms.Label();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.lblVacunas = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.lblInyeccion = new System.Windows.Forms.Label();
            this.txtInyeccion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblDire = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pbxCP_02 = new System.Windows.Forms.PictureBox();
            this.gboxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSexo
            // 
            this.cbxSexo.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.cbxSexo.Location = new System.Drawing.Point(69, 146);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(97, 24);
            this.cbxSexo.TabIndex = 24;
            this.cbxSexo.Text = "Eliga:";
            // 
            // dtp1
            // 
            this.dtp1.CalendarFont = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(239, 148);
            this.dtp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(148, 23);
            this.dtp1.TabIndex = 23;
            // 
            // gboxTipo
            // 
            this.gboxTipo.BackColor = System.Drawing.Color.Transparent;
            this.gboxTipo.Controls.Add(this.lblTipo);
            this.gboxTipo.Controls.Add(this.txtOtro);
            this.gboxTipo.Controls.Add(this.rbtnOtro);
            this.gboxTipo.Controls.Add(this.rbtnPerro);
            this.gboxTipo.Controls.Add(this.rbtnGato);
            this.gboxTipo.ForeColor = System.Drawing.Color.Transparent;
            this.gboxTipo.Location = new System.Drawing.Point(-3, 97);
            this.gboxTipo.Margin = new System.Windows.Forms.Padding(0);
            this.gboxTipo.Name = "gboxTipo";
            this.gboxTipo.Padding = new System.Windows.Forms.Padding(0);
            this.gboxTipo.Size = new System.Drawing.Size(395, 41);
            this.gboxTipo.TabIndex = 11;
            this.gboxTipo.TabStop = false;
            this.gboxTipo.Text = "groupBox1";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(3, 14);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(70, 18);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Especie:";
            // 
            // txtOtro
            // 
            this.txtOtro.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtro.Location = new System.Drawing.Point(303, 12);
            this.txtOtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(87, 23);
            this.txtOtro.TabIndex = 8;
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOtro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnOtro.Location = new System.Drawing.Point(229, 14);
            this.rbtnOtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(64, 21);
            this.rbtnOtro.TabIndex = 9;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "Otro:";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnPerro
            // 
            this.rbtnPerro.AutoSize = true;
            this.rbtnPerro.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnPerro.Location = new System.Drawing.Point(155, 14);
            this.rbtnPerro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPerro.Name = "rbtnPerro";
            this.rbtnPerro.Size = new System.Drawing.Size(64, 21);
            this.rbtnPerro.TabIndex = 9;
            this.rbtnPerro.TabStop = true;
            this.rbtnPerro.Text = "Perro";
            this.rbtnPerro.UseVisualStyleBackColor = true;
            // 
            // rbtnGato
            // 
            this.rbtnGato.AutoSize = true;
            this.rbtnGato.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnGato.Location = new System.Drawing.Point(83, 14);
            this.rbtnGato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGato.Name = "rbtnGato";
            this.rbtnGato.Size = new System.Drawing.Size(62, 21);
            this.rbtnGato.TabIndex = 9;
            this.rbtnGato.TabStop = true;
            this.rbtnGato.Text = "Gato";
            this.rbtnGato.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 20;
            // 
            // txtAmo
            // 
            this.txtAmo.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmo.Location = new System.Drawing.Point(89, 36);
            this.txtAmo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmo.Name = "txtAmo";
            this.txtAmo.Size = new System.Drawing.Size(301, 23);
            this.txtAmo.TabIndex = 22;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(281, 185);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(48, 18);
            this.lblPeso.TabIndex = 15;
            this.lblPeso.Text = "Peso:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(177, 150);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(56, 18);
            this.lblNacimiento.TabIndex = 16;
            this.lblNacimiento.Text = "Nació:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(3, 150);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 18);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(91, 71);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(78, 18);
            this.lblPaciente.TabIndex = 18;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblAmo
            // 
            this.lblAmo.AutoSize = true;
            this.lblAmo.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmo.Location = new System.Drawing.Point(91, 14);
            this.lblAmo.Name = "lblAmo";
            this.lblAmo.Size = new System.Drawing.Size(159, 18);
            this.lblAmo.TabIndex = 19;
            this.lblAmo.Text = "Nombre del Dueñ@:";
            // 
            // btnAgrega
            // 
            this.btnAgrega.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega.Location = new System.Drawing.Point(75, 464);
            this.btnAgrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(100, 30);
            this.btnAgrega.TabIndex = 13;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(253, 464);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSenas
            // 
            this.lblSenas.AutoSize = true;
            this.lblSenas.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenas.Location = new System.Drawing.Point(3, 185);
            this.lblSenas.Name = "lblSenas";
            this.lblSenas.Size = new System.Drawing.Size(149, 18);
            this.lblSenas.TabIndex = 15;
            this.lblSenas.Text = "Señas Particulares:";
            this.lblSenas.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(328, 183);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 23);
            this.textBox2.TabIndex = 21;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(9, 206);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(175, 69);
            this.txtPaciente.TabIndex = 21;
            // 
            // lblEsteril
            // 
            this.lblEsteril.AutoSize = true;
            this.lblEsteril.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteril.Location = new System.Drawing.Point(189, 222);
            this.lblEsteril.Name = "lblEsteril";
            this.lblEsteril.Size = new System.Drawing.Size(102, 18);
            this.lblEsteril.TabIndex = 15;
            this.lblEsteril.Text = "Esterilizado:";
            this.lblEsteril.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnSi.Location = new System.Drawing.Point(296, 220);
            this.rbtnSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(40, 21);
            this.rbtnSi.TabIndex = 9;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Sí";
            this.rbtnSi.UseVisualStyleBackColor = true;
            this.rbtnSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnNo.Location = new System.Drawing.Point(341, 220);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(49, 21);
            this.rbtnNo.TabIndex = 9;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblVacunas
            // 
            this.lblVacunas.AutoSize = true;
            this.lblVacunas.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacunas.Location = new System.Drawing.Point(189, 255);
            this.lblVacunas.Name = "lblVacunas";
            this.lblVacunas.Size = new System.Drawing.Size(89, 18);
            this.lblVacunas.TabIndex = 15;
            this.lblVacunas.Text = "Vacunado:";
            this.lblVacunas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(296, 254);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sí";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(341, 254);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(169, 185);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 18);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEd.Location = new System.Drawing.Point(217, 185);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(58, 17);
            this.lblEd.TabIndex = 15;
            this.lblEd.Text = "__ años";
            // 
            // lblInyeccion
            // 
            this.lblInyeccion.AutoSize = true;
            this.lblInyeccion.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInyeccion.Location = new System.Drawing.Point(1, 284);
            this.lblInyeccion.Name = "lblInyeccion";
            this.lblInyeccion.Size = new System.Drawing.Size(219, 18);
            this.lblInyeccion.TabIndex = 15;
            this.lblInyeccion.Text = "Indique qué vacunas posee:";
            this.lblInyeccion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInyeccion
            // 
            this.txtInyeccion.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInyeccion.Location = new System.Drawing.Point(9, 306);
            this.txtInyeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInyeccion.Multiline = true;
            this.txtInyeccion.Name = "txtInyeccion";
            this.txtInyeccion.Size = new System.Drawing.Size(379, 75);
            this.txtInyeccion.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(77, 394);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel1.Location = new System.Drawing.Point(12, 396);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(60, 18);
            this.lblTel1.TabIndex = 15;
            this.lblTel1.Text = "Telf. 1:";
            this.lblTel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel2.Location = new System.Drawing.Point(204, 396);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(60, 18);
            this.lblTel2.TabIndex = 15;
            this.lblTel2.Text = "Telf. 2:";
            this.lblTel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(269, 394);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDire.Location = new System.Drawing.Point(11, 426);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(85, 18);
            this.lblDire.TabIndex = 15;
            this.lblDire.Text = "Dirección:";
            this.lblDire.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(101, 423);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 23);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pbxCP_02
            // 
            this.pbxCP_02.BackgroundImage = global::Visual.Properties.Resources.CP_02;
            this.pbxCP_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCP_02.Location = new System.Drawing.Point(7, 5);
            this.pbxCP_02.Margin = new System.Windows.Forms.Padding(0);
            this.pbxCP_02.Name = "pbxCP_02";
            this.pbxCP_02.Size = new System.Drawing.Size(69, 69);
            this.pbxCP_02.TabIndex = 14;
            this.pbxCP_02.TabStop = false;
            // 
            // FrmPacienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(402, 503);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.gboxTipo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbtnSi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtInyeccion);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtAmo);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblDire);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.lblSenas);
            this.Controls.Add(this.lblInyeccion);
            this.Controls.Add(this.lblVacunas);
            this.Controls.Add(this.lblEsteril);
            this.Controls.Add(this.lblEd);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblAmo);
            this.Controls.Add(this.pbxCP_02);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPacienteNuevo";
            this.Text = "Animalito Nuevo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPacienteNuevo_FormClosing);
            this.Load += new System.EventHandler(this.FrmPacienteNuevo_Load);
            this.gboxTipo.ResumeLayout(false);
            this.gboxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.GroupBox gboxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.RadioButton rbtnPerro;
        private System.Windows.Forms.RadioButton rbtnGato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAmo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblAmo;
        private System.Windows.Forms.PictureBox pbxCP_02;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSenas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblEsteril;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.Label lblVacunas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.Label lblInyeccion;
        private System.Windows.Forms.TextBox txtInyeccion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.TextBox textBox5;
    }
}