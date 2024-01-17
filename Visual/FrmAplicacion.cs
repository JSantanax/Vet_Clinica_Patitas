using Controller;
using System;
using System.Windows.Forms;


namespace Visual
{
    public class FrmAplicacion : Form
    {
        Label lblSistema = null, lblDueno = null, lblDirec = null,
            lblCorreo = null, lblTelef = null, lbl1 = null, lbl2 = null, lbl3 = null;
        PictureBox pBox01 = null;
        Button btnCerrar = null;
        Control_Veterinario ctrlVet = new Control_Veterinario();

        //ControlInfo ctrlPrimos = new ControlInfo();
        public FrmAplicacion()
        {
            CrearControles();




            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CrearControles()
        {
            this.Text = "Información";
            this.ClientSize = new System.Drawing.Size(350, 190);
            this.BackColor = System.Drawing.Color.Thistle;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Icon = new System.Drawing.Icon("../Images/CP_00.ico");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInfo_FormClosing);

            // Imagen
            pBox01 = new System.Windows.Forms.PictureBox();
            pBox01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            //pBox01.Image = global::Visual.Properties.Resources.CP_03;
            pBox01.Location = new System.Drawing.Point(22, 24);
            pBox01.Margin = new System.Windows.Forms.Padding(0);
            pBox01.Name = "pBox01";
            pBox01.Size = new System.Drawing.Size(93, 101);
            pBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pBox01.TabIndex = 0;
            pBox01.TabStop = false;

            // App
            lblSistema = new Label();
            lblSistema.Location = new System.Drawing.Point(190, 10);
            lblSistema.Text = "App Patitas";
            lblSistema.Font = new System.Drawing.Font("Eras Bold ITC", 9,
                System.Drawing.FontStyle.Bold);
            lblSistema.AutoSize = true;

            // Dueño
            lblDueno = new Label();
            lblDueno.Location = new System.Drawing.Point(140, 35);
            lblDueno.Text = "Dueño:";
            lblDueno.Font = new System.Drawing.Font("Eras Bold ITC", 9);
            lblDueno.AutoSize = true;

            // Dirección
            lblDirec = new Label();
            lblDirec.Location = new System.Drawing.Point(140, 50);
            lblDirec.Text = "Eras Bold ITC:";
            lblDirec.Font = new System.Drawing.Font("Eras Bold ITC", 9);
            lblDirec.AutoSize = true;

            // Correo
            lblCorreo = new Label();
            lblCorreo.Location = new System.Drawing.Point(140, 65);
            lblCorreo.Text = "Correo:";
            lblCorreo.Font = new System.Drawing.Font("Eras Bold ITC", 9);
            lblCorreo.AutoSize = true;

            // Teléfono
            lblTelef = new Label();
            lblTelef.Location = new System.Drawing.Point(140, 80);
            lblTelef.Text = "Teléfono:";
            lblTelef.Font = new System.Drawing.Font("Eras Bold ITC", 9);
            lblTelef.AutoSize = true;

            // lbl1
            lbl1 = new Label();
            lbl1.Name = "lbl1";
            lbl1.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular);
            lbl1.Location = new System.Drawing.Point(140, 95);
            lbl1.Name = "lbl1";
            lbl1.Text = "Copyright 2023 POE VaSan.";
            lbl1.AutoSize = true;

            // lbl2
            lbl2 = new Label();
            lbl2.Name = "lbl2";
            lbl2.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular);
            lbl2.Location = new System.Drawing.Point(155, 110);
            lbl2.Text = "Derechos Reservados.";
            lbl2.AutoSize = true;

            // lbl3
            lbl3 = new Label();
            lbl3.Name = "lbl3";
            lbl3.Font = new System.Drawing.Font("Eras Demi ITC", 8F, System.Drawing.FontStyle.Regular);
            lbl3.Location = new System.Drawing.Point(170, 125);
            lbl3.Text = "Versión 1.0.15";
            lbl3.AutoSize = true;

            // Botón OK
            btnCerrar = new Button();
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(60, 30);
            btnCerrar.Location = new System.Drawing.Point(
                (ClientSize.Width - btnCerrar.Width) / 2, 150);
            btnCerrar.Text = "OK";
            btnCerrar.Click += BtnCerrar_Click;

            // Init
            Controls.Add(pBox01);
            Controls.Add(lblSistema);
            Controls.Add(lblDueno);
            Controls.Add(lblDirec);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelef);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(btnCerrar);
        }

        //private void llenaInfo()
        //{
        //    //pBox01.Image = new System.Drawing.Icon(DB_App.consultarInfo().Img)
        //    lblSistema.Text = ctrlVet.consultarInfo().listInfo.;


        //}

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Gracias por preferirnos",
              "",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
