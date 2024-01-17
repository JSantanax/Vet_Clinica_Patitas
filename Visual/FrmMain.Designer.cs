namespace Visual
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.flyPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVeterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreAppPatitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIng = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnWap = new System.Windows.Forms.Button();
            this.pbxCP_02 = new System.Windows.Forms.PictureBox();
            this.BackGround_01 = new System.Windows.Forms.PictureBox();
            this.flyPanel1.SuspendLayout();
            this.mstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_01)).BeginInit();
            this.SuspendLayout();
            // 
            // flyPanel1
            // 
            this.flyPanel1.Controls.Add(this.mstMain);
            this.flyPanel1.Location = new System.Drawing.Point(76, 3);
            this.flyPanel1.Name = "flyPanel1";
            this.flyPanel1.Size = new System.Drawing.Size(340, 36);
            this.flyPanel1.TabIndex = 2;
            this.flyPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flyPanel1_Paint);
            // 
            // mstMain
            // 
            this.mstMain.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.mstMain.BackColor = System.Drawing.Color.Thistle;
            this.mstMain.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.veterinarioToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripMenuItem1});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(340, 28);
            this.mstMain.TabIndex = 0;
            this.mstMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.revisarToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Image = global::Visual.Properties.Resources.Agenda_01;
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
            // 
            // revisarToolStripMenuItem
            // 
            this.revisarToolStripMenuItem.Image = global::Visual.Properties.Resources.Buscar_01;
            this.revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            this.revisarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.revisarToolStripMenuItem.Text = "Revisar";
            this.revisarToolStripMenuItem.Click += new System.EventHandler(this.revisarToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.visualizarToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Image = global::Visual.Properties.Resources.Plus_01;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Image = global::Visual.Properties.Resources.Buscar_01;
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.visualizarToolStripMenuItem.Text = "buscarVeterinario";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // veterinarioToolStripMenuItem
            // 
            this.veterinarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVeterinarioToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.buscarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            this.veterinarioToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.veterinarioToolStripMenuItem.Text = "Veterinario";
            this.veterinarioToolStripMenuItem.Click += new System.EventHandler(this.farmaciaToolStripMenuItem_Click);
            // 
            // agregarVeterinarioToolStripMenuItem
            // 
            this.agregarVeterinarioToolStripMenuItem.Image = global::Visual.Properties.Resources.Plus_01;
            this.agregarVeterinarioToolStripMenuItem.Name = "agregarVeterinarioToolStripMenuItem";
            this.agregarVeterinarioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.agregarVeterinarioToolStripMenuItem.Text = "Agregar";
            this.agregarVeterinarioToolStripMenuItem.Click += new System.EventHandler(this.agregarVeterinarioToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::Visual.Properties.Resources.Agenda_01;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.buscarToolStripMenuItem.Text = "Listar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::Visual.Properties.Resources.Actualizar_01;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Image = global::Visual.Properties.Resources.Buscar_01;
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.buscarToolStripMenuItem1.Text = "buscarVeterinario";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Visual.Properties.Resources.Borrar_01;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Thistle;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(15, 24);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreAppPatitasToolStripMenuItem,
            this.centroDeAyudaToolStripMenuItem,
            this.buscarActualizacionesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem1.Text = "Ayuda";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sobreAppPatitasToolStripMenuItem
            // 
            this.sobreAppPatitasToolStripMenuItem.Name = "sobreAppPatitasToolStripMenuItem";
            this.sobreAppPatitasToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.sobreAppPatitasToolStripMenuItem.Text = "Sobre App Patitas";
            this.sobreAppPatitasToolStripMenuItem.Click += new System.EventHandler(this.sobreAppPatitasToolStripMenuItem_Click);
            // 
            // centroDeAyudaToolStripMenuItem
            // 
            this.centroDeAyudaToolStripMenuItem.Name = "centroDeAyudaToolStripMenuItem";
            this.centroDeAyudaToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.centroDeAyudaToolStripMenuItem.Text = "Centro de Ayuda";
            // 
            // buscarActualizacionesToolStripMenuItem
            // 
            this.buscarActualizacionesToolStripMenuItem.Name = "buscarActualizacionesToolStripMenuItem";
            this.buscarActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.buscarActualizacionesToolStripMenuItem.Text = "buscarVeterinario Actualizaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(170, 207);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIng
            // 
            this.btnIng.BackColor = System.Drawing.Color.Transparent;
            this.btnIng.BackgroundImage = global::Visual.Properties.Resources.IG_01;
            this.btnIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIng.FlatAppearance.BorderSize = 0;
            this.btnIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIng.ForeColor = System.Drawing.Color.Transparent;
            this.btnIng.Location = new System.Drawing.Point(21, 178);
            this.btnIng.Margin = new System.Windows.Forms.Padding(0);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(30, 30);
            this.btnIng.TabIndex = 5;
            this.btnIng.UseVisualStyleBackColor = false;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.Transparent;
            this.btnTwitter.BackgroundImage = global::Visual.Properties.Resources.X_01;
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.ForeColor = System.Drawing.Color.Transparent;
            this.btnTwitter.Location = new System.Drawing.Point(21, 134);
            this.btnTwitter.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(30, 30);
            this.btnTwitter.TabIndex = 5;
            this.btnTwitter.UseVisualStyleBackColor = false;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnWap
            // 
            this.btnWap.BackColor = System.Drawing.Color.Transparent;
            this.btnWap.BackgroundImage = global::Visual.Properties.Resources.Wap_01;
            this.btnWap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWap.FlatAppearance.BorderSize = 0;
            this.btnWap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWap.ForeColor = System.Drawing.Color.Transparent;
            this.btnWap.Location = new System.Drawing.Point(21, 90);
            this.btnWap.Margin = new System.Windows.Forms.Padding(0);
            this.btnWap.Name = "btnWap";
            this.btnWap.Size = new System.Drawing.Size(30, 30);
            this.btnWap.TabIndex = 5;
            this.btnWap.Tag = "";
            this.btnWap.UseVisualStyleBackColor = false;
            // 
            // pbxCP_02
            // 
            this.pbxCP_02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCP_02.BackgroundImage")));
            this.pbxCP_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCP_02.Location = new System.Drawing.Point(5, 5);
            this.pbxCP_02.Margin = new System.Windows.Forms.Padding(0);
            this.pbxCP_02.Name = "pbxCP_02";
            this.pbxCP_02.Size = new System.Drawing.Size(69, 69);
            this.pbxCP_02.TabIndex = 0;
            this.pbxCP_02.TabStop = false;
            // 
            // BackGround_01
            // 
            this.BackGround_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGround_01.Image = global::Visual.Properties.Resources.BG_01;
            this.BackGround_01.Location = new System.Drawing.Point(75, 30);
            this.BackGround_01.Name = "BackGround_01";
            this.BackGround_01.Size = new System.Drawing.Size(299, 225);
            this.BackGround_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround_01.TabIndex = 4;
            this.BackGround_01.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 249);
            this.Controls.Add(this.btnIng);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnWap);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.flyPanel1);
            this.Controls.Add(this.pbxCP_02);
            this.Controls.Add(this.BackGround_01);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Patitas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.flyPanel1.ResumeLayout(false);
            this.flyPanel1.PerformLayout();
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCP_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCP_02;
        private System.Windows.Forms.FlowLayoutPanel flyPanel1;
        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVeterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem sobreAppPatitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarActualizacionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox BackGround_01;
        private System.Windows.Forms.Button btnWap;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
    }
}

