using Controller;
using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmEliminarVet : Form
    {
        Control_Veterinario ctrVet = new Control_Veterinario();
        public FrmEliminarVet()
        {
            InitializeComponent();

            //if (ctrVet.tamanioLista() > 0)
            //{
            //    ctrVet.listaVeterinarios(dgvVeterinarios);
            //    int count = dgvVeterinarios.RowCount - 1;
            //    lblReg.Text = count.ToString();
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarVet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la ventana?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ind = dgvVeterinarios.SelectedRows[0].Index;
            if (ind >= 0)
            {
                ctrVet.eliminaVeterinarios(dgvVeterinarios, ind);
            }
        }

        private void lblEspecialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
