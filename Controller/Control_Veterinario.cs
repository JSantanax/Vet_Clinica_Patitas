using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controller
{
    public class Control_Veterinario
    {
        static List<Persona> lstVet = new List<Persona>();
        //public List<Informacion> informa = new List<Informacion> ();
        Veterinario vet = null;
        DB_Connection conDB = new DB_Connection();
        VetDat VetDat = new VetDat();
        static int codigo = 1;

        public Control_Veterinario()
        {
            lstVet = listaVeterinariosDB();
        }

        private List<Persona> listaVeterinariosDB()
        {
            List<Persona> lst = null;
            string mj = conDB.conectar();
            //string rsp = "";
            if (mj[0] == '1')
            {
                lst = VetDat.listarVets(conDB.Connect);
            }
            else if (mj[0] == '0')
            {
                MessageBox.Show("Conexión errónea." + mj);
            }
            return lst;
        }

        public int Codigo { get => codigo; set => codigo = value; }

        //Métodos:
        public string registarVeterinario(string cod, string nom, string gen, string mail,
            string ced, DateTime fecha, string espe, string tel,
            string cel, string dire)
        {
            string mj = "";
            vet = new Veterinario(cod, nom, gen, mail, ced, fecha, espe, tel, cel, dire);

            //lstVet.Add(vet);
            //regVetDB(vet);
            mj = "El veterinari@ " + nom + " con especialidad en " + espe + ", nacido el " + fecha.ToString("yyyy-MM-dd") + ", se ha registrado exitosamente.";

            return mj;
        }

        private void regVetDB(Veterinario veterinario)
        {
            string mj = conDB.conectar();
            string rsp = "";
            if (mj[0] == '1')
            {
                rsp = VetDat.ingresarVeterinario(veterinario, conDB.Connect);
            }
            else if (mj[0] == '0')
            {
                MessageBox.Show("Conexión errónea." + mj);
            }
        }

        public int tamanioLista()
        {
            return lstVet.Count;
        }

        private void tablaVet(DataGridView dgvVeterinarios)
        {
            int ind = 0;
            //string code = vet.Especialidad.Substring(0, 4).ToUpper() + "-" + vet.Cedula.Substring(6, 4) +"-" + vet.Codigo;

            ind = dgvVeterinarios.Rows.Add();
            dgvVeterinarios.Rows[ind].Cells["colIndice"].Value = vet.IdVeterinario;
            dgvVeterinarios.Rows[ind].Cells["colCodigo"].Value = "F";
            dgvVeterinarios.Rows[ind].Cells["colVeterinario"].Value = vet.Nombres;
            dgvVeterinarios.Rows[ind].Cells["colGenero"].Value = vet.Genero;
            dgvVeterinarios.Rows[ind].Cells["colEspecialidad"].Value = vet.Especialidad;
            dgvVeterinarios.Rows[ind].Cells["colNacimiento"].Value = vet.Nacimiento;
            //dgvVeterinarios.Rows[ind].Cells["colEdad"].Value = vet.Edad;
            dgvVeterinarios.Rows[ind].Cells["colTelefono"].Value = vet.Telefono;
            dgvVeterinarios.Rows[ind].Cells["colCelular"].Value = vet.Celular;
            dgvVeterinarios.Rows[ind].Cells["colCorreo"].Value = vet.Mail;
            dgvVeterinarios.Rows[ind].Cells["colDir"].Value = vet.Direccion;
        }
        public void listaVeterinarios(DataGridView dgvVeterinarios)
        {
            dgvVeterinarios.Rows.Clear();
            foreach (Persona veterinario in lstVet)
            {
                if (veterinario is Veterinario)
                {
                    vet = (Veterinario)veterinario;
                    tablaVet(dgvVeterinarios);
                }
            }
        }

        public void filtra(DataGridView dgvVeterinarios, string especialidad, string genero)
        {
            dgvVeterinarios.Rows.Clear();
            foreach (Persona veterinario in lstVet)
            {
                if (veterinario is Veterinario)
                {
                    vet = (Veterinario)veterinario;
                    if (vet.Especialidad == especialidad && vet.Genero == genero)
                    {
                        tablaVet(dgvVeterinarios);
                    }
                }
            }
        }

        public void eliminaVeterinarios(DataGridView dgvVeterinarios, int ind)
        {
            string vCodigo = dgvVeterinarios.Rows[ind].Cells["colCodigo"].Value.ToString();

            DialogResult resp = MessageBox.Show("¿Desea desactivar el registro " + vCodigo + "?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resp == DialogResult.Yes)
            {
                dgvVeterinarios.Rows.RemoveAt(ind);
                lstVet.RemoveAt(lstVet.IndexOf(lstVet.ElementAt(ind)));
                MessageBox.Show("El registro con código " + vCodigo + " fue removido exitosamente.");
            }
        }

        public void buscarVeterinario(string dato)
        {
            string nombre, celular;
            int ind = 0;
            if (!string.IsNullOrEmpty(dato))
            {
                ind = Int32.Parse(dato.Substring(10, 1));
                //vet.Codigo = dato;
                int v = lstVet.IndexOf(lstVet.ElementAt(ind));

                nombre = lstVet[ind].Nombres; celular = lstVet[ind].Celular;
                //Form.FrmBuscarVet.lblNombre.Text = nombre;
            }
        }

        internal List<Veterinario> GetVeterinarios()
        {
            throw new NotImplementedException();
        }
    }
}