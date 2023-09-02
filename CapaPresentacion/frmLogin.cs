using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaDatos;
using CapaPresentacion.Lenguajes;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        List<string> Bloqueo = new List<string>();
        int i;
        
        public frmLogin()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsLogin BuscarUsuario = new clsLogin();
            clsLogin Ejecutar = new clsLogin();
            DataTable tabla = new DataTable();
            tabla = Ejecutar.VerifActivo(txtUsuario.Text);
            string activo = "True";
            
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    activo = row[0].ToString();
                }
            }
            if (activo=="False") 
            {
                MessageBox.Show("USUARIO BLOQUEADO");
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else if (BuscarUsuario.LoginUser(txtUsuario.Text, txtPassword.Text) == false)
            {
                UserCache.Usuario = txtUsuario.Text;
                Bloqueo.Add(txtUsuario.Text);
                CN_clsBitacora Guardar = new CN_clsBitacora("Ingreso Denegado", "Nivel Alto", "Login");
                MessageBox.Show("Usuario o Password inexistente");
                int ContarIntento = 0;
                for (i = 0; Bloqueo.Count > i; i++)
                {
                    if(txtUsuario.Text.Equals(Bloqueo[i]))
                    {
                        ContarIntento = ContarIntento + 1;
                    }
                    if(ContarIntento == 3)
                    {
                        Ejecutar.BloquearUsuario(txtUsuario.Text);
                        CN_clsBitacora Bloqueo = new CN_clsBitacora("Usuario Bloqueado", "Nivel Alto", "Login");
                    }
                }
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
                       
            
            else
            {
               
                MessageBox.Show("Bienvenid@: \n" + UserCache.Nombre+" \n"+UserCache.Apellido+"\n Rol: "+UserCache.Rol, "Ingreso Exitoso");
                this.DialogResult = DialogResult.OK;
                CN_clsBitacora Guardar = new CN_clsBitacora("Ingreso Exitoso", "Nivel Bajo", "Login");
                switch (UserCache.Rol)
                {
                    case "Administración":
                        
                        frmMenuAdmin menuAdm = new frmMenuAdmin();
                        menuAdm.Show();
                        this.Close();
                        break;

                    case "Recepción":
                        frmMenuPrincipal menu = new frmMenuPrincipal();
                        menu.Show();
                        this.Close();
                        break;

                    case "Contaduria":
                        frmContaduria frm = new frmContaduria();
                        frm.Show();
                        this.Close();
                        break;
                }
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña pass = new frmCambiarContraseña();
            pass.Show();
        }
    }
}
