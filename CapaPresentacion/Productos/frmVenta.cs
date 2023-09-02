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

namespace CapaPresentacion.Productos
{
    public partial class frmVenta : Form
    {
        int id;
        float total = 0;
        //int subtotal = 0;
        List<clsPrecarga> precargas = new List<clsPrecarga>();
        clsVentas objetoCN = new clsVentas();
        public frmVenta()
        {
            InitializeComponent();
            //Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            lblUser.Text =  UserCache.Usuario;
            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbComestibles, "Productos", "IdProducto", "Descripcion", "Tipo='Comestibles'");
            CN_LlenarCombos llenarCMB2 = new CN_LlenarCombos(cmbIndumentaria, "Productos", "IdProducto", "Descripcion", "Tipo='Indumentaria'");
            pnlVentas.Enabled = false;
        }
        private void BuscarClienteId(int id)
        {
            clsClientes objeto = new clsClientes();
            dtgVenta.DataSource = objeto.BuscarCli(id);
        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            BuscarClienteId(Convert.ToInt32(txtIdCliente.Text));

        }
        
        private void dtgVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                id = dtgVenta.CurrentCell.RowIndex;
                SelectCliente(Convert.ToInt32(dtgVenta.CurrentRow.Cells["IdCliente"].Value));
                lblClienteSelect.Text = "Cliente: "+ClientCache.Nombre+" "+ClientCache.Apellido;
                if(ClientCache.IdCliente != 0)
                {
                    pnlVentas.Enabled = true;
                }
                dtgVenta.DataSource = null;
            }
            catch
            {
                MessageBox.Show("No se encontro Cliente");
            }
            
        }
        
        public void SelectCliente(int IdCliente)
        {
            clsClientes objeto = new clsClientes();
            DataTable dt = new DataTable();
            dt = objeto.BuscarCli(IdCliente);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ClientCache.IdCliente = Convert.ToInt32(row[0].ToString());
                    ClientCache.Nombre = row[1].ToString();
                    ClientCache.Apellido = row[2].ToString();
                    ClientCache.Abono = row[3].ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            precargas.Add(new clsPrecarga()
            {
                Vendedor = UserCache.Usuario,
                IdCliente = ClientCache.IdCliente,
                Producto = cmbComestibles.Text,
                Cantidad = nmrComestible.Value,
                Precio = ProductCache.Precio,
                SubTotal = ProductCache.Precio*(float)nmrComestible.Value,
            });
            dtgVenta.DataSource = precargas;
            ActualizarListadoPrecarga();
            total = total + ProductCache.Precio * (float)nmrComestible.Value;
            lblTotal2.Text= total.ToString();
            LC2(pnlVentas);
        }
       
        private void btnAgregar2_Click(object sender, EventArgs e)
        {

            precargas.Add(new clsPrecarga()
            {
                Vendedor = UserCache.Usuario,
                IdCliente = ClientCache.IdCliente,
                Producto = cmbIndumentaria.Text,
                Cantidad = nmrIndumentaria.Value,
                Precio = ProductCache.Precio,
                SubTotal = ProductCache.Precio * (float)nmrIndumentaria.Value,
            });
            dtgVenta.DataSource = precargas;
            ActualizarListadoPrecarga();
            total = total + ProductCache.Precio * (float)nmrIndumentaria.Value;
            lblTotal2.Text = total.ToString();
            LC2(pnlVentas);
        }
        private void ActualizarListadoPrecarga()
        {
            dtgVenta.DataSource = null;
            dtgVenta.DataSource = precargas;
        }
        private void nmrIndumentaria_ValueChanged(object sender, EventArgs e)
        {
            //decimal cantIndumentaria = nmrIndumentaria.Value;
        }

        private void nmrComestible_ValueChanged(object sender, EventArgs e)
        {
            //decimal cantComestible = nmrComestible.Value;
        }
        private void SeleccionarProducto(int id)
        {
            CD_Productos objeto = new CD_Productos();
            DataTable dt = new DataTable();
            dt = objeto.SeleccionarProducto(id);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ProductCache.IdProducto = Convert.ToInt32(row[0].ToString());
                    ProductCache.Nombre = row[1].ToString();
                    ProductCache.Descripcion = row[2].ToString();
                    ProductCache.Stock = Convert.ToInt32(row[3].ToString());
                    ProductCache.Precio = float.Parse(row[4].ToString());
                    ProductCache.Tipo = row[5].ToString();
                }
            }
        }

        private void cmbComestibles_Leave(object sender, EventArgs e)
        {
            SeleccionarProducto(Convert.ToInt32(cmbComestibles.SelectedValue.ToString()));
        }

        private void cmbIndumentaria_Leave(object sender, EventArgs e)
        {
            SeleccionarProducto(Convert.ToInt32(cmbIndumentaria.SelectedValue.ToString()));
        }

        private void chcNoCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chcNoCliente.Checked)
            {
                pnlVentas.Enabled = true;
                ClientCache.IdCliente = 0;
            }
            else
            {
                pnlVentas.Enabled  = false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            pnlVentas.Enabled = false;
            lblTotal2.Text = "0";
            total = 0;
            precargas.Clear();
            dtgVenta.DataSource = null;
            lblClienteSelect.Text = "Cliente comprador";
        }
        public static void LimpiarControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = null;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = null;
                }
                if (c is GroupBox | c is Panel)
                {
                    LC2(c);
                }
            }
        }

        private static void LC2(Control x)
        {
            foreach (Control h in x.Controls)
            {
                if (h is TextBox)
                {
                    ((TextBox)h).Text = null;
                }
                if (h is ComboBox)
                {
                    ((ComboBox)h).Text = null;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarFacturacion_Click(object sender, EventArgs e)
        {
            objetoCN.InsertarVent(dtpFactura.Value, UserCache.IdUsuario, Convert.ToInt32(lblTotal2.Text), ClientCache.IdCliente);
        }

        private void dtgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
