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


namespace CapaPresentacion
{
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            clsCambiarContraseña CC = new clsCambiarContraseña();
                try
                {
                    CC.CambioPass(txtUsuario.Text, txtPassword.Text, txtNewPass.Text, txtNewPass2.Text);
                    MessageBox.Show("CAMBIO REALIZADO CORRECTAMENTE, VUELVA A INGRESAR CON LA NUEVA CONTRASEÑA.", "CAMBIO EXITOSO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.ToString(),
                        "ERROR EN CAMBIO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
