using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public class InfoDat
    {
        SqlCommand cmd = new SqlCommand();

        public List<Informacion> listarInfo(SqlConnection connect)
        {
            List<Informacion> lstInfo = new List<Informacion>();
            Informacion info = null;

            SqlDataReader read = null;
            string command = "SELECT * from Informacion";

            try
            {
                cmd.Connection = connect;
                cmd.CommandText = command;
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    info = new Informacion();
                    info.IdApp = (int)read["idApp"];
                    info.Sistema = (string)read["Sistema"];
                    info.Dueno = (string)read["Dueño"];
                    info.Direccion = (string)read["Dirección"];
                    info.Correo = (string)read["Correo"];
                    info.Telefono = (string)read["Teléfono"];
                    info.Imagen = (string)read["Imagen"];
                    lstInfo.Add(info);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return lstInfo;
        }
    }
}