namespace Visual
{
    partial class FrmEliminarVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarVet));
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.colDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PtbBuscarPaciente = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(426, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 28);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Eliminar Veterinari@s";
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.BackgroundColor = System.Drawing.Color.PaleVioletRed;
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
            this.colDir});
            this.dgvVeterinarios.Location = new System.Drawing.Point(11, 155);
            this.dgvVeterinarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.RowHeadersWidth = 51;
            this.dgvVeterinarios.Size = new System.Drawing.Size(1089, 200);
            this.dgvVeterinarios.TabIndex = 56;
            // 
            // colIndice
            // 
            this.colIndice.HeaderText = "Nº";
            this.colIndice.MinimumWidth = 6;
            this.colIndice.Name = "colIndice";
            this.colIndice.Width = 35;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 80;
            // 
            // colVeterinario
            // 
            this.colVeterinario.HeaderText = "Nombres";
            this.colVeterinario.MinimumWidth = 6;
            this.colVeterinario.Name = "colVeterinario";
            this.colVeterinario.Width = 150;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Género";
            this.colGenero.MinimumWidth = 6;
            this.colGenero.Name = "colGenero";
            this.colGenero.Width = 70;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.MinimumWidth = 6;
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.Width = 80;
            // 
            // colNacimiento
            // 
            this.colNacimiento.HeaderText = "F. Nacimiento";
            this.colNacimiento.MinimumWidth = 6;
            this.colNacimiento.Name = "colNacimiento";
            this.colNacimiento.Width = 80;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Width = 70;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.MinimumWidth = 6;
            this.colCelular.Name = "colCelular";
            this.colCelular.Width = 70;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "C. Electrónico";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Width = 150;
            // 
            // colDir
            // 
            this.colDir.HeaderText = "Dirección";
            this.colDir.MinimumWidth = 6;
            this.colDir.Name = "colDir";
            this.colDir.Width = 250;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblRegistros.Location = new System.Drawing.Point(396, 114);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(267, 23);
            this.lblRegistros.TabIndex = 52;
            this.lblRegistros.Text = "Número total de Registros:";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistros.Click += new System.EventHandler(this.lblEspecialidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(595, 367);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PtbBuscarPaciente
            // 
            this.PtbBuscarPaciente.BackgroundImage = global::Visual.Properties.Resources.CP_03;
            this.PtbBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbBuscarPaciente.Location = new System.Drawing.Point(332, 15);
            this.PtbBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.PtbBuscarPaciente.Name = "PtbBuscarPaciente";
            this.PtbBuscarPaciente.Size = new System.Drawing.Size(87, 74);
            this.PtbBuscarPaciente.TabIndex = 53;
            this.PtbBuscarPaciente.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(445, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblReg.Location = new System.Drawing.Point(671, 114);
            this.lblReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 23);
            this.lblReg.TabIndex = 52;
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReg.Click += new System.EventHandler(this.lblEspecialidad_Click);
            // 
            // FrmEliminarVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1108, 399);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVeterinarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.PtbBuscarPaciente);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEliminarVet";
            this.Text = "Eliminar Veterinari@s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEliminarVet_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private System.Windows.Forms.PictureBox PtbBuscarPaciente;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblReg;
    }
}