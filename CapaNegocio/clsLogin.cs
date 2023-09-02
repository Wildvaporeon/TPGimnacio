using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio 
{
    public class clsLogin : CD_Conexion
    {
        private bool existe;
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        clsConectarUsuario userLogin = new clsConectarUsuario();

        public bool LoginUser(string user, string pass)
        {
            existe = userLogin.Login(user, clsEncriptación.SHA256(pass));

            return existe;
        }
        public void EjecucionDirecta(string sSql)
        {
            using (SqlConnection CNN = GetConexion())
            {
                CNN.Open();
                using (SqlCommand comando = new SqlCommand(sSql, CNN))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        public DataTable VerifActivo(string usuario)
        {
                using (SqlConnection cn = GetConexion())
                {
                    cn.Open();
                    comando.Connection = cn;
                    comando.CommandText = "VerificarActivo";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usuario", usuario);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    
                    adaptador.Fill(tabla);
                    comando.Parameters.Clear();
                    return tabla;
                }
        }
        public void BloquearUsuario(string usuario)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BloquearUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }

    }
}
