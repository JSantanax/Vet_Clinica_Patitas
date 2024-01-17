using Controller;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmVeterNuevo : Form
    {
        Control_Veterinario ctrVet = new Control_Veterinario();
        public FrmVeterNuevo()
        {
            InitializeComponent();
        }

        private void lblNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblNomApeVet_Click(object sender, EventArgs e)
        {

        }

        private void txtNomApeVet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVeterNuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Desea salir de la ventana?",
            //  "Consulta",
            //  MessageBoxButtons.YesNo,
            //  MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomApeVet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nom = e.KeyChar;
            if (!char.IsLetter(nom) && nom != (Convert.ToChar(Keys.Back)) && nom != (Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char correo = e.KeyChar;
            //if (txtCorreo.Text != string.Empty && Regex.IsMatch(txtCorreo.Text,
            //    @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && correo != (Convert.ToChar(Keys.Space)))
            //{
            //    e.Handled = true;
            //    return;
            //}
            //else { MessageBox.Show("Ingresar correo válido."); }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ced = e.KeyChar;

            if (!char.IsNumber(ced) && ced != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
            else if (txtCedula.TextLength >= 10 && ced != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tel = e.KeyChar;
            if (!char.IsDigit(tel) && tel != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
            else if (txtTelefono.TextLength >= 9 && tel != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cel = e.KeyChar;
            if (!char.IsDigit(cel) && cel != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
            else if (txtCelular.TextLength >= 10 && cel != (Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            string cod = (String)cbxEspecialidad.SelectedItem;
            string ced = txtCedula.Text.Trim();
            string ape = txtNomApeVet.Text.Split(' ')[3].ToString();

            DateTime fecha = dtpNacimiento.Value;
            string code = cod.Substring(0, 4).ToUpper() + "-" + ape.ToUpper() + "-" + ced.Substring(6, 4);
            string nombres = txtNomApeVet.Text.Trim(), genero = (String)cbxSexo.SelectedItem,
                mail = txtCorreo.Text.Trim(), cedula = txtCedula.Text.Trim(),                
                especialidad = (String)cbxEspecialidad.SelectedItem,
                telefono = txtTelefono.Text.Trim(), celular = txtCelular.Text.Trim(),
                direccion = txtDireccion.Text.Trim(), nac = fecha.ToString("dd-MM-yyyy");
            
            string resp = "";

            if (!string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(genero) &&
                !string.IsNullOrEmpty(mail) && !string.IsNullOrEmpty(cedula) &&
                !string.IsNullOrEmpty(nac) && !string.IsNullOrEmpty(especialidad) &&
                !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(celular) &&
                !string.IsNullOrEmpty(direccion))
            {
                resp = ctrVet.registarVeterinario(code, nombres, genero, mail, cedula, fecha,
                especialidad, telefono, celular, direccion);
                MessageBox.Show(resp);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            if (txtCorreo.Text != string.Empty && Regex.IsMatch(txtCorreo.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ingresar correo válido.");
                txtCorreo.Focus();
            }
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}