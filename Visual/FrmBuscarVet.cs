using Controller;
using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmBuscarVet : Form
    {
        Control_Veterinario ctrVet = new Control_Veterinario();
        public FrmBuscarVet()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBuscarVet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la ventana?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int col = 0;
            string dato = txtCodigo.Text.Trim();

            if (!string.IsNullOrEmpty(dato))
            {
                ctrVet.buscarVeterinario(dato);
            }

            //int ind = dgvVeterinarios.SelectedRows[0].Index;
            //if (ind >= 0)
            //{
            //    ctrVet.eliminaVeterinarios(dgvVeterinarios, ind);
            //}
        }

        private void FrmBuscarVet_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            Form frmAgendaVeterinario = new FrmAgendar();
            frmAgendaVeterinario.ShowDialog();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
