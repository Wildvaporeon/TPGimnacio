using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        int n=1;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }
        private void frmMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            lblUser.Text = lblUser.Text +": "+ UserCache.Usuario;
            if(UserCache.Rol== "Administración")
            {
                btnDesloguear.Visible = false;
            }
            InitializeDataGridView();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (UserCache.Rol != "Administración")
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void btnDesloguear_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            LimpiarCache();

        }

        private void btnAdmClientes_Click(object sender, EventArgs e)
        {
            frmAdmClientes frm = new frmAdmClientes();
            frm.ShowDialog();
            
        }
        private void btnGestionClases_Click(object sender, EventArgs e)
        {
            frmGestionClases frm  = new frmGestionClases();
            frm.ShowDialog();
        }
        private void btnGestionTurnos_Click(object sender, EventArgs e)
        {

        }
        private void btnVentaProductos_Click(object sender, EventArgs e)
        {
            Productos.frmVenta frm = new Productos.frmVenta();
            frm.ShowDialog();
        }
        private void btnGestionAbono_Click(object sender, EventArgs e)
        {
            frmGestionAbono frm = new frmGestionAbono();
            frm.ShowDialog();

        }
        private void btnReposProductos_Click_1(object sender, EventArgs e)
        {
            frmReposProductos frm = new frmReposProductos();
            frm.ShowDialog();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserCache.Rol != "Administración")
            {
                Application.Exit();
            }

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            clsIngreso BuscarCliente = new clsIngreso();
            try
            {
                if (BuscarCliente.IngresoCliente(Convert.ToInt32(txtIngreso.Text)) == false)
                {
                    dtgIngreso.Rows.Add(n, txtIngreso.Text, "DESCONOCIDO RECHAZADO", datetime);
                    n++;
                    CN_clsBitacora Guardar = new CN_clsBitacora("DESCONOCIDO RECHAZADO ID: " + txtIngreso.Text + "", "Nivel Alto", "Ingreso de Clientes");
                    MessageBox.Show("Intento de ingreso desconocido");
                }
                else if (DateTime.Compare(DateTime.Now, ClientCache.AptoFisico) >= 1)
                {
                    dtgIngreso.Rows.Add(n, txtIngreso.Text, "AF VENCIDO", datetime);
                    n++;
                    CN_clsBitacora Guardar = new CN_clsBitacora("AF VENCIDO ID: " + txtIngreso.Text + "", "Nivel Medio", "Ingreso de Clientes");
                    frmFicha frm = new frmFicha();
                    frm.ShowDialog();
                }
                else
                {
                    dtgIngreso.Rows.Add(n, txtIngreso.Text, "Acceso concedido", datetime);
                    n++;
                    CN_clsBitacora Guardar = new CN_clsBitacora("Acceso concedido ID: "+txtIngreso.Text+"", "Nivel Bajo", "Ingreso de Clientes");
                    frmFicha frm = new frmFicha();
                    frm.ShowDialog();
                }
                txtIngreso.Clear();

            }   
            catch(Exception)
            {
                MessageBox.Show("ID Erroneo");
            }
            
        }
        private void LimpiarCache()
        {
            UserCache.Usuario = null;
            UserCache.Password = null;
            UserCache.Apellido = null;
            UserCache.Nombre = null;
            UserCache.Rol = null;
            UserCache.IdUsuario = 0;
        }
        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dtgIngreso.ColumnCount = 4;
            dtgIngreso.ColumnHeadersVisible = true;
            /*
            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtgIngreso.ColumnHeadersDefaultCellStyle = columnHeaderStyle;*/

            // Set the column header names.
            dtgIngreso.Columns[0].Name = "N°";
            dtgIngreso.Columns[1].Name = "ID";
            dtgIngreso.Columns[2].Name = "Detalle";
            dtgIngreso.Columns[3].Name = "Horario";
        }
            private void dtgIngreso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
