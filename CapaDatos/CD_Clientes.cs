using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes: CD_Conexion
    {
        
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "MostrarClientes";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }

        public DataTable BuscarCliente(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BuscarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }
        public DataTable BuscarDni(int dni)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BuscarDni";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@dni", dni);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }
        public void Insertar(string nombre, string apellido, string direccion, string localidad, string provincia, int dni, DateTime fechaNac, string genero, int celular, int telefono, string email, string abono, byte[] xfoto, DateTime aptoFisico)
        {
            //PROCEDIMIENTO
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Localidad", localidad);
                comando.Parameters.AddWithValue("@Provincia", provincia);
                comando.Parameters.AddWithValue("@Dni", dni);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", fechaNac);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Abono", abono);
                comando.Parameters.AddWithValue("@Foto", xfoto);
                comando.Parameters.AddWithValue("@AptoFisico", aptoFisico);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        }

        public void Editar(string nombre, string apellido, string direccion, string localidad, string provincia, int dni, DateTime fechaNac, string genero, int celular, int telefono, string email, string abono, byte [] xfoto, int id, DateTime aptoFisico)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EditarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Localidad", localidad);
                comando.Parameters.AddWithValue("@Provincia", provincia);
                comando.Parameters.AddWithValue("@Dni", dni);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", fechaNac);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Abono", abono);
                comando.Parameters.AddWithValue("@Foto", xfoto);
                comando.Parameters.AddWithValue("@IdCliente", id);
                comando.Parameters.AddWithValue("@AptoFisico", aptoFisico);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EliminarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }


        }

        public DataTable Consultar(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "ConsultarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", id);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla);
                return tabla;
            }


        }

    }
}
