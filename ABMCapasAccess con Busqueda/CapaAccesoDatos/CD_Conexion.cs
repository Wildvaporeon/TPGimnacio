using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace CapaAccesoDatos
{
    public class CD_Conexion
    {
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Personas.accdb";

        private OleDbConnection CN;
        private OleDbCommand comando;
        private DataTable DT;
        private OleDbDataAdapter DA;
        

        //public OleDbConnection AbrirConexion()
        //{
        //    CN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Personas.accdb");
        //    if (CN.State == ConnectionState.Open )
        //    {
        //        CN.Close();
        //    }
        //    CN.Open();

        //    return CN;
        //}

        //public OleDbConnection CerrarConexion()
        //{
        //    CN.Close();
        //    return CN;
        //}
        
        protected void EjecucionDirecta(string sSql)//update, set etc
        {
            using ( CN = new OleDbConnection(cadenaConexion))
            {
                CN.Open();
                using (comando = new OleDbCommand(sSql, CN))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        protected DataTable EjecutarBusqueda(string sSql)//cuando le preguntas algo a la bd
        {
            using (CN = new OleDbConnection(cadenaConexion))
            {
                CN.Open();
                using (DA = new OleDbDataAdapter(sSql, CN))
                {
                    DT= new DataTable();
                    DA.Fill(DT);
                    return DT;
                }
            }
        }


    }
}
