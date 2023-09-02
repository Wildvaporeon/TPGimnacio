using System.Data;
using System.Data.SqlClient;

/* Esta clase me permite cargar cualquier comboBox desde una tabla
   recibiendo  el Nombre de la tabala, el campo Id de la tabla relacionado al dato que mostrara el ComboBox 
   y el campo que mostrara el ComboBox.
   como opcional podra recibir una condicion .
*/
namespace CapaDatos
{
    public class CD_LlenarCombos : CD_Conexion
    {

        #region ATRIBUTOS
        private string tabla;
        private string campoid;
        private string campodescrip;
        private string condicion;
        /*SqlDataReader leer;
        DataTable res = new DataTable();
        SqlCommand comando = new SqlCommand();*/
        #endregion

        #region PROPERTIES
        
        public string Tabla
        {
            set { tabla = value; }
        }
        public string CampoId
        {
            set { campoid = value; }
        }
        public string CampoDescrip
        {
            set { campodescrip = value; }
        }
        public string Condicion
        {
            set { condicion = value; }
        }
        #endregion


        public DataTable CargarCMB()
        {
            string sSql;
            if (condicion == "")
            {
               sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " ORDER BY " + campodescrip;
                 //return CargarCombos(campoid, campodescrip, tabla);
            }
            else
            {
                sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campodescrip;
                //return CargarCombos(campoid, campodescrip, tabla, condicion);
            }

            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            return Ejecutar.Ejecutar(sSql);
        }
        /*public DataTable CargarCombos(string campoid, string campodescrip, string tabla)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "CargarCombo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@campoid", campoid);
                comando.Parameters.AddWithValue("@campodescrip", campodescrip);
                comando.Parameters.AddWithValue("@tabla", tabla);
                leer = comando.ExecuteReader();
                res.Load(leer);
                comando.Parameters.Clear();
                return res;
            }
        }
        public DataTable CargarCombos(string campoid, string campodescrip, string tabla, string condicion)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "CargarComboCondicion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@campoid", campoid);
                comando.Parameters.AddWithValue("@campodescrip", campodescrip);
                comando.Parameters.AddWithValue("@tabla", tabla);
                comando.Parameters.AddWithValue("@condicion", condicion);
                leer = comando.ExecuteReader();
                res.Load(leer);
                comando.Parameters.Clear();
                return res;
            }
        }*/
    }
}

