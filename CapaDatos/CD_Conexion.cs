using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private string cadenaConexion = "Data Source=DESKTOP-N6GSPV3;Initial Catalog=gimnasio;Integrated Security=True";

        //"Data Source=LAPTOP-9L2C9UHO\\SQLEXPRESS;Initial Catalog=gimnasio;Integrated Security=True"



        protected SqlConnection GetConexion() // property que devuelve la conexion
        {
            return new SqlConnection(cadenaConexion);
        }


    }
}
