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
    public class clsVentas
    {
        private CD_Ventas objetoCD = new CD_Ventas();
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public string IdCliente { get; set; }
        public string Localidad { get; set; }

        public void InsertarVent(DateTime fecha, int idusuario, int total, int idcliente)
        {
            objetoCD.InsertarVenta(fecha, idusuario, total, idcliente);
        }
        public DataTable TotalVent()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.TotalVentas();
            return tabla;
        }
    }
}
