using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public class VetDat
    {
        SqlCommand cmd = new SqlCommand();
        public string ingresarVeterinario(Veterinario veterinario, SqlConnection connect)
        {
            string resp = "";
            string command = "INSERT INTO Veterinario_Tbl(Código, Nombres, Nacimiento, Género, Cédula, Teléfono," +
                "Celular, Especialidad, Correo, Dirección) VALUES ('" + veterinario.Codigo + "','" + veterinario.Nombres + "'," +
                "'" + veterinario.Nacimiento.ToString() + "','" + veterinario.Genero + "','" + veterinario.Cedula + "'," +
                "'" + veterinario.Telefono + "','" + veterinario.Celular + "','" + veterinario.Especialidad + "','" + veterinario.Mail + "'," +
                "'" + veterinario.Direccion + "')";
            try
            {
                cmd.Connection = connect;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
                resp = "1";
            }
            catch (SqlException ex)
            {
                resp = "0" + ex; ;
                Console.WriteLine("Error: " + ex);
            }
            return resp;
        }

        public List<Persona> listarVets(SqlConnection connect)
        {
            List<Persona> lst = new List<Persona>();
            Veterinario veterinario = null;

            SqlDataReader rdr = null;
            string command = "SELECT * from Veterinario_Tbl";

            try
            {
                cmd.Connection = connect;
                cmd.CommandText = command;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    veterinario = new Veterinario();
                    veterinario.IdVeterinario = (int)rdr["IdVeterinario"];
                    veterinario.Codigo = (string)rdr["Código"];
                    veterinario.Nombres = (string)rdr["Nombres"];
                    veterinario.Nacimiento = (DateTime)rdr["Nacimiento"];
                    veterinario.Genero = (string)rdr["Género"];
                    veterinario.Cedula = (string)rdr["Cédula"];
                    veterinario.Telefono = (string)rdr["Teléfono"];
                    veterinario.Celular = (string)rdr["Celular"];
                    veterinario.Especialidad = (string)rdr["Especialidad"];
                    veterinario.Mail = (string)rdr["Correo"];
                    veterinario.Direccion = (string)rdr["Dirección"];
                    lst.Add(veterinario);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            return lst;
        }
    }
}