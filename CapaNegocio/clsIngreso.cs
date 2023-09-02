using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsIngreso
    {
        private bool existe;

        clsIngresoCliente ingreso = new clsIngresoCliente();
        //clsPermisos Permisos = new clsPermisos();
        public bool IngresoCliente(int idcliente)
        {
            existe = ingreso.Ingreso(idcliente);
            //existe = userLoguin.Login(user, pass);
            /*if (existe)
            {
                Permisos.Permisos(UserCache.IdUsuario);
            }*/
            return existe;
        }
    }
}
