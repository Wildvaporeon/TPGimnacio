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
    public class clsClientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();
        public int IdCliente { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }   
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public int Dni { get; set; }
        public DateTime FechaDeNac { get; set; }
        public string Genero { get; set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Abono { get; set; }
        public byte [] xfoto { get; set; }
        public DateTime aptoFisico { get; set; }

        public DataTable MostrarCli()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable BuscarCli(int id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarCliente(id);
            return tabla;
        }
        public DataTable BuscarDoc(int dni)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarDni(dni);
            return tabla;
        }

        public void EliminarCli(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public DataTable ConsultarCli(int id)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Consultar(id);
            return tabla;
        }
        public void InsertarCli(string nombre, string apellido, string direccion, string localidad, string provincia, int dni, DateTime fechaNac, string genero, int celular, int telefono, string email, string abono, byte[] xfoto, DateTime aptoFisico)
        {

            objetoCD.Insertar(nombre, apellido, direccion, localidad, provincia, dni, fechaNac,  genero, celular, telefono, email, abono, xfoto, aptoFisico);
        }

        public void EditarCli(string nombre, string apellido, string direccion, string localidad, string provincia, int dni, DateTime fechaNac, string genero, int celular, int telefono, string email, string abono, byte [] xfoto, string id, DateTime aptoFisico)
        {
            objetoCD.Editar(nombre, apellido, direccion, localidad, provincia, dni, fechaNac, genero, celular, telefono, email, abono, xfoto, Convert.ToInt32(id), aptoFisico);
        }
    }
}
