using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empleados: CD_Conexion
    {

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarEmpleados()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "MostrarEmpleados";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }
        public DataTable MostrarUsuarios()
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "MostrarUsuarios";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;
            }

        }

        public DataTable BuscarEmpleado(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BuscarEmpleadoId";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }
        public DataTable BuscarEmpleadoCuil(string cuil)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "BuscarEmpleadoCuil";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cuil", cuil);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
            }
        }
        public void InsertarUsuario(int id, string nombre, string apellido, string usuario, string contraseña, int idrol, bool activo)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@IdRol", idrol);
                comando.Parameters.AddWithValue("@Activo", activo);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        public void EditarUsuario(int id, string usuario, string contraseña,int idemp)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EditarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdUsuario", id);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@IdEmpleado", idemp);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        
        public void EliminarUsuario(int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EliminarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }


        }
        public void CambiarContraseña(string usuario, string contraseña)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "CambiarContraseña";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        public void RolBloq(int id, int idrol, bool activo)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "RolesBloqueos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdUsuario", id);
                comando.Parameters.AddWithValue("@IdRol", idrol);
                comando.Parameters.AddWithValue("@Activo", activo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        public DataTable ConsulRol(int id, int idrol)
        {
                using (SqlConnection cn = GetConexion())
                {
                    cn.Open();
                    comando.Connection = cn;
                    comando.CommandText = "ConsultarRol";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdUsuario", id);
                    comando.Parameters.AddWithValue("@IdRol", idrol);
                    leer = comando.ExecuteReader();
                    tabla.Load(leer);
                    comando.Parameters.Clear();
                    return tabla;
                }
        }

        public void Insertar(string nombre, string apellido, string direccion, string localidad, string provincia, string cuil, DateTime fechaNac, string genero, int celular, int telefono, string email, string sector)
        {
            //PROCEDIMIENTO
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "InsertarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Localidad", localidad);
                comando.Parameters.AddWithValue("@Provincia", provincia);
                comando.Parameters.AddWithValue("@Cuil", cuil);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", fechaNac);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Sector", sector);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        }

        public void Editar(string nombre, string apellido, string direccion, string localidad, string provincia, string cuil, DateTime fechaNac, string genero, int celular, int telefono, string email, string sector, int id)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "EditarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Localidad", localidad);
                comando.Parameters.AddWithValue("@Provincia", provincia);
                comando.Parameters.AddWithValue("@Cuil", cuil);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", fechaNac);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Sector", sector);
                comando.Parameters.AddWithValue("@IdEmpleado", id);

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
                comando.CommandText = "EliminarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id);
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
                comando.CommandText = "ConsultarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla);
                return tabla;
            }


        }
        public DataTable ConsultarUsuario(string usuario)
        {
            using (SqlConnection cn = GetConexion())
            {
                cn.Open();
                comando.Connection = cn;
                comando.CommandText = "ConsultarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", usuario);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                return tabla;
                /*SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla);*/
            }


        }

    }
}
