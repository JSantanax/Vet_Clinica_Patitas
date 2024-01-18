namespace Visual
{
    partial class FrmListarVet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarVet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.PtbBuscarPaciente = new System.Windows.Forms.PictureBox();
            this.veterinarioDataSet = new Visual.VeterinarioDataSet();
            this.veterinarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.colIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioDataSet1 = new Visual.VeterinarioDataSet1();
            this.veterinario_TblTableAdapter = new Visual.VeterinarioDataSet1TableAdapters.Veterinario_TblTableAdapter();
            this.btnElimFilt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Eras Bold ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(521, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 28);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Listar Veterinari@s";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblEspecialidad.Location = new System.Drawing.Point(268, 119);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(150, 23);
            this.lblEspecialidad.TabIndex = 50;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEspecialidad.Click += new System.EventHandler(this.lblEspecialidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(550, 358);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblGenero.Location = new System.Drawing.Point(539, 119);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(86, 23);
            this.lblGenero.TabIndex = 50;
            this.lblGenero.Text = "Género:";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidad.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Items.AddRange(new object[] {
            "Cirugía",
            "Dermatología",
            "Fisioterapia",
            "Oftalmología",
            "Oncología",
            "Ortopedia",
            "General"});
            this.cbxEspecialidad.Location = new System.Drawing.Point(418, 117);
            this.cbxEspecialidad.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(110, 26);
            this.cbxEspecialidad.TabIndex = 59;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbxSexo.Location = new System.Drawing.Point(625, 117);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(70, 26);
            this.cbxSexo.TabIndex = 60;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::Visual.Properties.Resources.Buscar_01;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltrar.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnFiltrar.Location = new System.Drawing.Point(721, 113);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(106, 34);
            this.btnFiltrar.TabIndex = 54;
            this.btnFiltrar.Text = "     Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // PtbBuscarPaciente
            // 
            this.PtbBuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtbBuscarPaciente.BackgroundImage")));
            this.PtbBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbBuscarPaciente.Location = new System.Drawing.Point(427, 19);
            this.PtbBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.PtbBuscarPaciente.Name = "PtbBuscarPaciente";
            this.PtbBuscarPaciente.Size = new System.Drawing.Size(87, 74);
            this.PtbBuscarPaciente.TabIndex = 53;
            this.PtbBuscarPaciente.TabStop = false;
            // 
            // veterinarioDataSet
            // 
            this.veterinarioDataSet.DataSetName = "VeterinarioDataSet";
            this.veterinarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinarioDataSetBindingSource
            // 
            this.veterinarioDataSetBindingSource.DataSource = this.veterinarioDataSet;
            this.veterinarioDataSetBindingSource.Position = 0;
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.AllowUserToAddRows = false;
            this.dgvVeterinarios.AllowUserToResizeColumns = false;
            this.dgvVeterinarios.AllowUserToResizeRows = false;
            this.dgvVeterinarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvVeterinarios.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndice,
            this.colCodigo,
            this.colVeterinario,
            this.colGenero,
            this.colEspecialidad,
            this.colNacimiento,
            this.colTelefono,
            this.colCelular,
            this.colCorreo,
            this.ColDir});
            this.dgvVeterinarios.Location = new System.Drawing.Point(18, 169);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.ReadOnly = true;
            this.dgvVeterinarios.RowHeadersWidth = 51;
            this.dgvVeterinarios.RowTemplate.Height = 24;
            this.dgvVeterinarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeterinarios.Size = new System.Drawing.Size(1125, 170);
            this.dgvVeterinarios.TabIndex = 62;
            // 
            // colIndice
            // 
            this.colIndice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIndice.HeaderText = "Nº";
            this.colIndice.MinimumWidth = 6;
            this.colIndice.Name = "colIndice";
            this.colIndice.ReadOnly = true;
            this.colIndice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIndice.Width = 25;
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigo.Width = 130;
            // 
            // colVeterinario
            // 
            this.colVeterinario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colVeterinario.HeaderText = "Nombres";
            this.colVeterinario.MinimumWidth = 6;
            this.colVeterinario.Name = "colVeterinario";
            this.colVeterinario.ReadOnly = true;
            this.colVeterinario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colVeterinario.Width = 200;
            // 
            // colGenero
            // 
            this.colGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGenero.HeaderText = "Género";
            this.colGenero.MinimumWidth = 6;
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGenero.Width = 60;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.MinimumWidth = 6;
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.ReadOnly = true;
            this.colEspecialidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEspecialidad.Width = 70;
            // 
            // colNacimiento
            // 
            this.colNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colNacimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNacimiento.HeaderText = "F.Nacimiento";
            this.colNacimiento.MinimumWidth = 6;
            this.colNacimiento.Name = "colNacimiento";
            this.colNacimiento.ReadOnly = true;
            this.colNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNacimiento.Width = 70;
            // 
            // colTelefono
            // 
            this.colTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTelefono.Width = 70;
            // 
            // colCelular
            // 
            this.colCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCelular.HeaderText = "Celular";
            this.colCelular.MinimumWidth = 6;
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCelular.Width = 80;
            // 
            // colCorreo
            // 
            this.colCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCorreo.HeaderText = "C. Electrónico";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCorreo.Width = 150;
            // 
            // ColDir
            // 
            this.ColDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColDir.HeaderText = "Dirección";
            this.ColDir.MinimumWidth = 6;
            this.ColDir.Name = "ColDir";
            this.ColDir.ReadOnly = true;
            this.ColDir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDir.Width = 200;
            // 
            // veterinarioTblBindingSource
            // 
            this.veterinarioTblBindingSource.DataMember = "Veterinario_Tbl";
            this.veterinarioTblBindingSource.DataSource = this.veterinarioDataSet1;
            // 
            // veterinarioDataSet1
            // 
            this.veterinarioDataSet1.DataSetName = "VeterinarioDataSet1";
            this.veterinarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinario_TblTableAdapter
            // 
            this.veterinario_TblTableAdapter.ClearBeforeFill = true;
            // 
            // btnElimFilt
            // 
            this.btnElimFilt.BackColor = System.Drawing.Color.Transparent;
            this.btnElimFilt.BackgroundImage = global::Visual.Properties.Resources.Borrar_01;
            this.btnElimFilt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElimFilt.FlatAppearance.BorderSize = 0;
            this.btnElimFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimFilt.ForeColor = System.Drawing.Color.Transparent;
            this.btnElimFilt.Location = new System.Drawing.Point(844, 116);
            this.btnElimFilt.Name = "btnElimFilt";
            this.btnElimFilt.Size = new System.Drawing.Size(33, 29);
            this.btnElimFilt.TabIndex = 61;
            this.btnElimFilt.UseVisualStyleBackColor = false;
            this.btnElimFilt.Click += new System.EventHandler(this.btnElimFilt_Click);
            // 
            // FrmListarVet
            // 
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1160, 400);
            this.Controls.Add(this.dgvVeterinarios);
            this.Controls.Add(this.btnElimFilt);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.PtbBuscarPaciente);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmListarVet";
            this.Text = "Listar Veterinari@s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuscarVet_FormClosing);
            this.Load += new System.EventHandler(this.FrmListarVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox PtbBuscarPaciente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.BindingSource veterinarioDataSetBindingSource;
        private VeterinarioDataSet veterinarioDataSet;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private VeterinarioDataSet1 veterinarioDataSet1;
        private System.Windows.Forms.BindingSource veterinarioTblBindingSource;
        private VeterinarioDataSet1TableAdapters.Veterinario_TblTableAdapter veterinario_TblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDir;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnElimFilt;
    }
}