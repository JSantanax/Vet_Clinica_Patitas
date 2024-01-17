using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class DB_Connection
    {
        public static string root = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        private SqlConnection connect = null;

        public SqlConnection Connect { get => connect; set => connect = value; }

        public string conectar()
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = root;
                connect.Open();
                return "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }

        public string desconectar()
        {
            try
            {
                connect.Close();
                return "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }
    }
}