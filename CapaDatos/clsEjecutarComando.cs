using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class clsEjecutarComando : CD_Conexion
    {
        SqlDataReader DR;
        private DataTable DT = new DataTable();

        public DataTable Ejecutar(string sSql)
        {


            using (SqlConnection CNN = GetConexion())
            {
                CNN.Open();
                using (SqlCommand comando = new SqlCommand(sSql, CNN))
                {
                    DR = comando.ExecuteReader();
                    DT.Load(DR);
                    return DT;
                }
            }
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
    }
}
