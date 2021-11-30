using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datos
    {
        private static readonly datos _instancia = new datos();
        public static datos Instancia
        {
            get { return datos._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-UPNK831\\MSQSERVER; Initial Catalog=ProyectoFinalMoansov1; Integrated Security=true";
            return cn;
        }
    }
}
