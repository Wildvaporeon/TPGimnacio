using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_clsBitacora: CD_Conexion
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public CD_clsBitacora(string evento, string criticidad, string origen)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            string hora = DateTime.Now.ToString("HH:mm");
            int IdUsuario = UserCache.IdUsuario;
            string usuario = UserCache.Usuario;
            
            InsertarBitacora(DateTime.Parse(fecha), DateTime.Parse(hora), IdUsuario,usuario,evento,criticidad,origen);

        }
        public CD_clsBitacora()
        {

        }
        public void InsertarBitacora( DateTime fecha, DateTime hora, int idusuario, string usuario, string evento, string criticidad, string origen)
        {

            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarBitacora";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Hora", hora);
                comando.Parameters.AddWithValue("@IdUsuario", idusuario);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Evento", evento);
                comando.Parameters.AddWithValue("@Criticidad", criticidad);
                comando.Parameters.AddWithValue("@Origen", origen);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        }

        public DataTable MostrarBitacora()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "MostrarBitacora";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }
        public DataTable FiltrarBitacoraOrigen(string origen)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "FiltrarBitacoraOrigen";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Origen", origen);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }
        public DataTable FiltrarBitacoraEvento(string evento)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "FiltrarBitacoraEvento";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Evento", evento);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }

    }
}
