using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class clsEmpleados
    {
        private CD_Empleados objetoCD = new CD_Empleados();
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string cuil { get; set; }
        public DateTime FechaDeNac { get; set; }
        public string Genero { get; set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }


        public DataTable MostrarEmp()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEmpleados();
            return tabla;
        }
        public DataTable MostrarUs()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarUsuarios();
            return tabla;
        }
        public DataTable BuscarEmp(int id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarEmpleado(id);
            return tabla;
        }
        public DataTable BuscarEmpCuil(string cuil)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarEmpleadoCuil(cuil);
            return tabla;
        }

        public void EliminarEmp(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public void InsertarEmp(string nombre, string apellido, string direccion, string localidad, string provincia, string cuil, DateTime fechaNac, string genero, int celular, int telefono, string email, string sector)
        {

            objetoCD.Insertar(nombre, apellido, direccion, localidad, provincia, cuil, fechaNac, genero, celular, telefono, email, sector);
        }
        public void EditarEmp(string nombre, string apellido, string direccion, string localidad, string provincia, string cuil, DateTime fechaNac, string genero, int celular, int telefono, string email, string sector, string id)
        {
            objetoCD.Editar(nombre, apellido, direccion, localidad, provincia, cuil, fechaNac, genero, celular, telefono, email, sector, Convert.ToInt32(id));
        }
        public void InsertarUs(int id, string nombre, string apellido, string usuario, string contraseña, int idrol, bool activo)
        {

            objetoCD.InsertarUsuario(id, nombre, apellido, usuario, contraseña, idrol, activo);
        }

        public void EditarUs(int id, string usuario, string contraseña, int idemp)
        {

            objetoCD.EditarUsuario(id, usuario, contraseña, idemp);
        }
        public void EliminarUs(string id)
        {

            objetoCD.EliminarUsuario(Convert.ToInt32(id));
        }
        public void EditarRolBloq(int id, int idrol, bool activo)
        {

            objetoCD.RolBloq(id, idrol, activo);
        }

        public DataTable ConsultarRol(int id, int idrol)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ConsulRol(id, idrol);
            return tabla;
        }
        public DataTable ConsultarUs(string usuario)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ConsultarUsuario(usuario);
            return tabla;
        }
        
    }
}
