using System;

namespace Model
{
    public class Veterinario : Persona
    {
        private int idVeterinario;
        private string cedula;
        private string especialidad;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int IdVeterinario { get => idVeterinario; set => idVeterinario = value; }

        public Veterinario()
        {
            cedula = "";
            especialidad = "";
        }

        public Veterinario(string codigo, string nom, string gen, string mail, string ced, DateTime fecha, string espe,
            string tel, string cel, string dire, int idVeterinario = 0)
        {
            this.Codigo = codigo;
            this.Nombres = nom;
            this.Genero = gen;
            this.mail = mail;
            this.Cedula = ced;
            this.Nacimiento = fecha;
            this.Especialidad = espe;
            this.Telefono = tel;
            this.Celular = cel;
            this.Direccion = dire;
            this.idVeterinario = idVeterinario;
        }
    }
}