using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_clsBackupRestore: CD_Conexion
    {
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        clsEjecutarComando Ejecutar = new clsEjecutarComando();
        public void BackupDB(string ruta)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BackupDB";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RutaNombre", ruta);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        public void RestoreDB(string ruta)
        {
            using (SqlConnection cn = GetConexion())
            {
                //cn.Open();
                //comando.Connection = cn;
                Ejecutar.EjecucionDirecta("USE [master]\n RESTORE DATABASE [gimnasio] FROM  DISK = N'"+ruta+"' WITH  FILE = 1,  NOUNLOAD,  STATS = 5");
                comando.Parameters.Clear();
            }
        }
        
    }
}
