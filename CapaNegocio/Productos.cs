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
    public class Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
        public string Tipo { get; set; }

        
        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable BuscarProd(string text)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarProducto(text);
            return tabla;
        }

        public DataTable SelectProd(int id)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.SeleccionarProducto(id);
            return tabla;
        }
        public void EliminarProd(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }
        
        public void InsertarProd(string nombre, string desc, string stock, string precio, string tipo)
        {

            objetoCD.Insertar(nombre, desc, Convert.ToInt32(stock), Convert.ToSingle(precio), tipo);
        }

        public void EditarProd(string nombre, string desc, string stock, string precio, string tipo, string id)
        {
            objetoCD.Editar(nombre, desc, Convert.ToInt32(stock), Convert.ToSingle(precio), tipo, Convert.ToInt32(id));
        }

        public void ReponerStock(int idProducto, int cantidad)
        {
            objetoCD.Reponer(idProducto, cantidad);
        }


    }
}
