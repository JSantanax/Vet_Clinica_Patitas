namespace Visual
{
    partial class FrmBuscarVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarVet));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCodUni = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblEspe = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNaci = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDire = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.ldlDireccion = new System.Windows.Forms.Label();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PtbBuscarVeterinario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(474, 327);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCodUni
            // 
            this.lblCodUni.AutoSize = true;
            this.lblCodUni.Font = new System.Drawing.Font("Eras Bold ITC", 11F);
            this.lblCodUni.Location = new System.Drawing.Point(243, 109);
            this.lblCodUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodUni.Name = "lblCodUni";
            this.lblCodUni.Size = new System.Drawing.Size(146, 23);
            this.lblCodUni.TabIndex = 64;
            this.lblCodUni.Text = "Código Único:";
            this.lblCodUni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(372, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 28);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "buscarVeterinario Veterinari@s";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(405, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(224, 25);
            this.txtCodigo.TabIndex = 72;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(50, 171);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 22);
            this.lblNombre.TabIndex = 73;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.ForeColor = System.Drawing.Color.Teal;
            this.lblVet.Location = new System.Drawing.Point(149, 171);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(293, 22);
            this.lblVet.TabIndex = 73;
            this.lblVet.Text = "Jorge Andrés Sornoza Santana";
            this.lblVet.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEspe
            // 
            this.lblEspe.AutoSize = true;
            this.lblEspe.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspe.Location = new System.Drawing.Point(483, 171);
            this.lblEspe.Name = "lblEspe";
            this.lblEspe.Size = new System.Drawing.Size(145, 22);
            this.lblEspe.TabIndex = 73;
            this.lblEspe.Text = "Especialidad:";
            this.lblEspe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEspe.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.Teal;
            this.lblEspecialidad.Location = new System.Drawing.Point(634, 171);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(201, 22);
            this.lblEspecialidad.TabIndex = 73;
            this.lblEspecialidad.Text = "Otorrinoralingólogo";
            this.lblEspecialidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(57, 222);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(90, 22);
            this.lblGen.TabIndex = 73;
            this.lblGen.Text = "Género:";
            this.lblGen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblGen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(482, 222);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(106, 22);
            this.lblTel.TabIndex = 73;
            this.lblTel.Text = "Teléfono:";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Teal;
            this.lblGenero.Location = new System.Drawing.Point(148, 222);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(102, 22);
            this.lblGenero.TabIndex = 73;
            this.lblGenero.Text = "Femenino";
            this.lblGenero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Teal;
            this.lblTelefono.Location = new System.Drawing.Point(587, 222);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(128, 22);
            this.lblTelefono.TabIndex = 73;
            this.lblTelefono.Text = "04-602-2132";
            this.lblTelefono.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNaci
            // 
            this.lblNaci.AutoSize = true;
            this.lblNaci.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaci.Location = new System.Drawing.Point(267, 222);
            this.lblNaci.Name = "lblNaci";
            this.lblNaci.Size = new System.Drawing.Size(74, 22);
            this.lblNaci.TabIndex = 73;
            this.lblNaci.Text = "Nació:";
            this.lblNaci.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNaci.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.ForeColor = System.Drawing.Color.Teal;
            this.lblNacimiento.Location = new System.Drawing.Point(343, 222);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(122, 22);
            this.lblNacimiento.TabIndex = 73;
            this.lblNacimiento.Text = "04/10/2023";
            this.lblNacimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(731, 222);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(89, 22);
            this.lblCel.TabIndex = 73;
            this.lblCel.Text = "Celular:";
            this.lblCel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Teal;
            this.lblCelular.Location = new System.Drawing.Point(823, 222);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(140, 22);
            this.lblCelular.TabIndex = 73;
            this.lblCelular.Text = "09-6991-6412";
            this.lblCelular.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(62, 268);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(85, 22);
            this.lblMail.TabIndex = 73;
            this.lblMail.Text = "Correo:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDire.Location = new System.Drawing.Point(476, 268);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(112, 22);
            this.lblDire.TabIndex = 73;
            this.lblDire.Text = "Dirección:";
            this.lblDire.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDire.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Teal;
            this.lblCorreo.Location = new System.Drawing.Point(149, 268);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(249, 22);
            this.lblCorreo.TabIndex = 73;
            this.lblCorreo.Text = "jsantana7000@gmail.com";
            this.lblCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldlDireccion
            // 
            this.ldlDireccion.AutoSize = true;
            this.ldlDireccion.Font = new System.Drawing.Font("Eras Bold ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlDireccion.ForeColor = System.Drawing.Color.Teal;
            this.ldlDireccion.Location = new System.Drawing.Point(587, 268);
            this.ldlDireccion.Name = "ldlDireccion";
            this.ldlDireccion.Size = new System.Drawing.Size(336, 22);
            this.ldlDireccion.TabIndex = 73;
            this.ldlDireccion.Text = "Samanes 7, etapa IV, Mz. 14, V. 134";
            this.ldlDireccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.Transparent;
            this.btnCita.BackgroundImage = global::Visual.Properties.Resources.Cita_01;
            this.btnCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCita.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.ForeColor = System.Drawing.Color.Transparent;
            this.btnCita.Location = new System.Drawing.Point(873, 87);
            this.btnCita.Margin = new System.Windows.Forms.Padding(0);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(65, 65);
            this.btnCita.TabIndex = 74;
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::Visual.Properties.Resources.Borrar_01;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Location = new System.Drawing.Point(770, 106);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(33, 29);
            this.btnBorrar.TabIndex = 71;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Visual.Properties.Resources.Buscar_01;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Font = new System.Drawing.Font("Eras Bold ITC", 9F);
            this.btnBuscar.Location = new System.Drawing.Point(647, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 34);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.Text = "     buscarVeterinario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PtbBuscarVeterinario
            // 
            this.PtbBuscarVeterinario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtbBuscarVeterinario.BackgroundImage")));
            this.PtbBuscarVeterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbBuscarVeterinario.Location = new System.Drawing.Point(278, 15);
            this.PtbBuscarVeterinario.Margin = new System.Windows.Forms.Padding(4);
            this.PtbBuscarVeterinario.Name = "PtbBuscarVeterinario";
            this.PtbBuscarVeterinario.Size = new System.Drawing.Size(87, 74);
            this.PtbBuscarVeterinario.TabIndex = 65;
            this.PtbBuscarVeterinario.TabStop = false;
            // 
            // FrmBuscarVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1008, 369);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.ldlDireccion);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNaci);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblDire);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblEspe);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.PtbBuscarVeterinario);
            this.Controls.Add(this.lblCodUni);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBuscarVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "buscarVeterinario Veterinari@s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuscarVet_FormClosing);
            this.Load += new System.EventHandler(this.FrmBuscarVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbBuscarVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox PtbBuscarVeterinario;
        private System.Windows.Forms.Label lblCodUni;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblEspe;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNaci;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label ldlDireccion;
        private System.Windows.Forms.Button btnCita;
    }
}