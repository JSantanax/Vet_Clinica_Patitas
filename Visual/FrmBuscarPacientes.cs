using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmBuscarPacientes : Form
    {
        public FrmBuscarPacientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaciente_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmBuscarPacientes_Load(object sender, EventArgs e)
        {

        }

        private void PtbBuscarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {

        }

        private void dtgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBuscarPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmBuscarPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la ventana?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
