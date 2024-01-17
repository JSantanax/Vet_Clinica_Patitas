using Controller;
using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmListarVet : Form
    {
        Control_Veterinario ctrVet = new Control_Veterinario();
        public FrmListarVet()
        {
            InitializeComponent();

            if (ctrVet.tamanioLista() > 0)
            {
                ctrVet.listaVeterinarios(dgvVeterinarios);
            }
        }


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dtgvVeterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void txtIngresarMascota_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnFiltrar_Click(object sender, EventArgs e)
        //{
        //    string especialidad = (String)cbxEspecialidad.SelectedItem;
        //    string genero = (String)cbxSexo.SelectedItem;

        //    if (!string.IsNullOrEmpty(especialidad) && !string.IsNullOrEmpty(genero))
        //    {
        //        ctrVet.filtra(dgvVeterinarios, especialidad, genero);
        //    }
        //}

        //private void btnBorrar_Click(object sender, EventArgs e)
        //{
        //    ctrVet.listaVeterinarios(dgvVeterinarios);
        //    cbxEspecialidad.SelectedIndex = -1;
        //    cbxSexo.SelectedIndex = -1;
        //}

        private void FrmListarVet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinarioDataSet1.Veterinario_Tbl' table. You can move, or remove it, as needed.
            //this.veterinario_TblTableAdapter.Fill(this.veterinarioDataSet1.Veterinario_Tbl);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string especialidad = (String)cbxEspecialidad.SelectedItem;
            string genero = (String)cbxSexo.SelectedItem;

            if (!string.IsNullOrEmpty(especialidad) && !string.IsNullOrEmpty(genero))
            {
                ctrVet.filtra(dgvVeterinarios, especialidad, genero);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnElimFilt_Click(object sender, EventArgs e)
        {
            ctrVet.listaVeterinarios(dgvVeterinarios);
            cbxEspecialidad.SelectedIndex = -1;
            cbxSexo.SelectedIndex = -1;
        }
    }
}