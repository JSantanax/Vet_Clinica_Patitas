using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmAgendar : Form
    {
        public FrmAgendar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la ventana?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {

        }
    }
}
