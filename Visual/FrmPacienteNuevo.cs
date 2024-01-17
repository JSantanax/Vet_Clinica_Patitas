using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmPacienteNuevo : Form
    {
        public FrmPacienteNuevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPacienteNuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la ventana?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPacienteNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {

        }
    }
}
