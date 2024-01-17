using System;

namespace Model
{
    public abstract class Persona
    {
        protected int edad;
        protected string codigo, nombres, genero, mail, direccion, telefono, celular;
        protected DateTime nacimiento;

        public string Codigo { get => codigo; set => codigo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}