namespace Visual
{
    partial class FrmApli
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
        private void CrearControles()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApli));
            this.pBox02 = new System.Windows.Forms.PictureBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox02)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox02
            // 
            this.pBox02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBox02.Image = global::Visual.Properties.Resources.CP_03;
            this.pBox02.Location = new System.Drawing.Point(22, 24);
            this.pBox02.Margin = new System.Windows.Forms.Padding(0);
            this.pBox02.Name = "pBox02";
            this.pBox02.Size = new System.Drawing.Size(93, 101);
            this.pBox02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBox02.TabIndex = 0;
            this.pBox02.TabStop = false;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Eras Bold ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(135, 36);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(96, 18);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "App Patitas";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(135, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(198, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Copyright 2023 POE VaSan.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(135, 75);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(155, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Derechos Reservados.";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(135, 94);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(107, 17);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Versión 1.0.15";
            // 
            // FrmAplicacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.pBox02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Patitas";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pBox02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox02;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
    }
}