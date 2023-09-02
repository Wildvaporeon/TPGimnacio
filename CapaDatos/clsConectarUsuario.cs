using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class clsConectarUsuario : CD_Conexion

    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public bool Login(string user, string pass)
        {

            DataTable DT = new DataTable();

            DT = LogueoUsuario(user, pass);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    UserCache.IdUsuario = Convert.ToInt32(row[0].ToString());
                    UserCache.Usuario = row[1].ToString();
                    UserCache.Password = row[2].ToString();
                    UserCache.Apellido = row[3].ToString();
                    UserCache.Nombre = row[4].ToString();
                    UserCache.Rol = row[5].ToString();

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable LogueoUsuario(string user, string pass)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "LogueoUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", user);
                comando.Parameters.AddWithValue("@Contraseña", pass);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }
    }
}
