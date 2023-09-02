using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class clsCambiarContraseña
    {
        clsConectarUsuario VerificaPass = new clsConectarUsuario();


        private bool existe;
        public bool CambioPass(string Usuario, string passVieja, string PassNueva, string PassNueva1)
        {

            existe = VerificaPass.Login(Usuario, clsEncriptación.SHA256(passVieja));
            if (existe)
            {
                if (PassNueva == PassNueva1)
                {
                    CD_Empleados CC = new CD_Empleados();
                    CC.CambiarContraseña(usuario: UserCache.Usuario, contraseña: clsEncriptación.SHA256(PassNueva));
                    CN_clsBitacora Guardar = new CN_clsBitacora("Cambio de contraseña", "Nivel Medio", "Login");
                }
                else
                {
                    throw new Exception("Las nuevas contraseñas ingresadas no coinciden.");
                }
            }
            else
            {
                throw new Exception("La contraseña ingresada es incorrecta.");
            }
            return true;
        }


    }
}
