using Controller;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmMain : Form
    {
        Control_Veterinario ctrVet = new Control_Veterinario();
        public FrmMain()
        {
            InitializeComponent();
            var tTip = new ToolTip();
            tTip.SetToolTip(btnWap, "+593 975 526 457");
            tTip.SetToolTip(btnTwitter, "@Cln_Patitas");
            tTip.SetToolTip(btnIng, "@ClnPatitas");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void flyPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAgenda = new FrmAgendar();
            frmAgenda.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Gracias por su visita",
              "",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNuevo = new FrmPacienteNuevo();
            frmNuevo.ShowDialog();
        }

        private void sobreAppPatitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmApp = new FrmAplicacion();
            frmApp.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarPacientes frmBuscarPacientes = new FrmBuscarPacientes();
            frmBuscarPacientes.ShowDialog();
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void revisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRevisar frmRevisar = new FrmRevisar();
            frmRevisar.ShowDialog();
        }

        private void farmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVeterinario = new FrmVeterNuevo();
            frmVeterinario.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarVet frmBuscaVet = null;
            if (ctrVet.tamanioLista() > 0)
            {
                frmBuscaVet = new FrmListarVet();
                frmBuscaVet.ShowDialog();
            }
            else { MessageBox.Show("No hay veterinarios registrados."); }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmEliminarVet frmEliminarVet = null;
            if (ctrVet.tamanioLista() > 0)
            {
                frmEliminarVet = new FrmEliminarVet();
                frmEliminarVet.ShowDialog();
            }
            else { MessageBox.Show("No hay veterinarios registrados."); }
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmBuscVeterinario = new FrmBuscarVet();
            frmBuscVeterinario.ShowDialog();
        }
    }
}
