using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class ClientCache
    {
        public static int IdCliente { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Abono { get; set; }
        public static DateTime AptoFisico { get; set; }
        public static byte[] Foto { get; set; }

    }
}
