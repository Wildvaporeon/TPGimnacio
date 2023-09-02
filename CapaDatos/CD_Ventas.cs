using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Ventas: CD_Conexion
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public void InsertarVenta(DateTime fecha, int idusuario, int total, int idcliente)
        {

            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarVenta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@IdUsuario", idusuario);
                comando.Parameters.AddWithValue("@Total", total);
                comando.Parameters.AddWithValue("@IdCliente", idcliente);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        }
        public DataTable TotalVentas()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "TotalVentas";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }

    }
}
