using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmReposProductos : Form
    {
        CapaNegocio.Productos objetoCN = new CapaNegocio.Productos();
        //private string idProducto = null;
        public frmReposProductos()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReposProductos_Load(object sender, EventArgs e)
        {
            lblUser.Text = lblUser.Text + ": " + UserCache.Usuario;
            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbProductos, "Productos", "IdProducto", "Descripcion");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int item = Convert.ToInt32(cmbProductos.SelectedValue.ToString());
            int cantidad = Convert.ToInt32(nmrCantProd.Value);

            objetoCN.ReponerStock(item, cantidad);
            MessageBox.Show("Se edito correctamente");
            this.Close();

        }
    }
}
