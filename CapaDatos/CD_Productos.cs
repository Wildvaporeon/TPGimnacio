using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Productos: CD_Conexion
    {
        //private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "MostrarProductos";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }
        
        public DataTable BuscarProducto(string text)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BuscarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@var", text);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
        }
        public DataTable SeleccionarProducto(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "SeleccionarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", id);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }
        }
        
        public void Insertar(string nombre, string desc, int stock, double precio, string tipo)
        {
            //PROCEDIMNIENTO
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProducto", nombre);
                comando.Parameters.AddWithValue("@Descripcion", desc);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Tipo", tipo);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }    

        }

        public void Editar(string nombre, string desc, int stock, double precio, string tipo, int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EditarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProducto", nombre);
                comando.Parameters.AddWithValue("@Descripcion", desc);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.Parameters.AddWithValue("@IdProducto", id);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            
        }

        public void Reponer(int idProducto, int cantidad)
        {
            
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "ReponerStock";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", idProducto);
                comando.Parameters.AddWithValue("@Stock", cantidad);

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
                comando.CommandText = "EliminarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", id);
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
                comando.CommandText = "ConsultarProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdProducto", id);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla);
                return tabla;
            }

            
        }

    }
}
