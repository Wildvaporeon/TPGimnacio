using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsIngresoCliente : CD_Conexion
    {
        private CD_Clientes objetoCD = new CD_Clientes();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public bool Ingreso(int idcliente)
        {

            DataTable DT = new DataTable();
            //clsEjecutarComando Ejecutar = new clsEjecutarComando();

            DT = IngresoCliente(idcliente);

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    ClientCache.IdCliente = Convert.ToInt32(row[0].ToString());
                    ClientCache.Nombre = row[1].ToString();
                    ClientCache.Apellido = row[2].ToString();
                    ClientCache.Abono = row[3].ToString();
                    ClientCache.AptoFisico = DateTime.Parse(row[4].ToString());
                    try
                    {
                        ClientCache.Foto = (byte[])row[5];
                    }
                    catch
                    {
                        return true;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public DataTable ConsultarCli(int id)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Consultar(id);
            return tabla;
        }

        public DataTable IngresoCliente(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "IngresoCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", id);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }

    }
}
