using Data;
using Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controller
{
    public class Control_Info
    {
        static List<Informacion> lstInfo = new List<Informacion>();
        DB_Connection conDB = new DB_Connection();
        InfoDat InfoDat = new InfoDat();

        public Control_Info()
        {
            lstInfo = InformacionBD();
        }

        private List<Informacion> InformacionBD()
        {
            List<Informacion> lst = null;
            string mj = conDB.conectar();
            string rsp = "";
            if (mj[0] == '1')
            {
                lst = InfoDat.listarInfo(conDB.Connect);
            }
            else if (mj[0] == '0')
            {
                MessageBox.Show("Conexión errónea." + mj);
            }
            return lst;
        }
    }
}
