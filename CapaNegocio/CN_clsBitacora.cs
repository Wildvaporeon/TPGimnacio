using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    
    public class CN_clsBitacora
    {
        private string evento;
        private string detalle;
        private string origen;
  
        public CN_clsBitacora(string evento, string detalle, string origen)
        {
            this.evento = evento;
            this.detalle = detalle;
            this.origen = origen;

            CD_clsBitacora Guardar = new CD_clsBitacora(evento, detalle, origen);
        }
        public CN_clsBitacora()
        {

        }
        public DataTable MostrarBit()
        {
        CD_clsBitacora consultar = new CD_clsBitacora();
        DataTable tabla = new DataTable();
        tabla = consultar.MostrarBitacora();
        return tabla;
        }
        public DataTable FiltBitOrigen(string origen)
        {
            CD_clsBitacora consultar = new CD_clsBitacora();
            DataTable tabla = new DataTable();
            tabla = consultar.FiltrarBitacoraOrigen(origen);
            return tabla;
        }
        public DataTable FiltBitEvento(string evento)
        {
            CD_clsBitacora consultar = new CD_clsBitacora();
            DataTable tabla = new DataTable();
            tabla = consultar.FiltrarBitacoraEvento(evento);
            return tabla;
        }
    }
    
    
}
