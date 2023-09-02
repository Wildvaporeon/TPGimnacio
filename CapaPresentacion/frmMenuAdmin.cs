using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMenuAdmin : Form
    {
        clsBackupRestore objetoCN = new clsBackupRestore();
    
        public frmMenuAdmin()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
            if(Thread.CurrentThread.CurrentUICulture.IetfLanguageTag=="en-US")
            {
                InglesMenu();
            }
        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            lblBitacora.Visible = false;
            dtgAdmin.Visible = false;
            btnX.Visible = false;
        }

        private void btnDesloguear_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            LimpiarCache();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
        private void DtgON()
        {
            if (dtgAdmin.Visible == false)
            {
                lblBitacora.Visible = true;
                dtgAdmin.Visible = true;
                btnX.Visible = true;
            }

        }
        private void administraciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.frmAdmUsuarios AbmUsuarios = new Usuarios.frmAdmUsuarios();
            AbmUsuarios.Show();
        }

        private void administraciónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmClientes AbmClientes = new frmAdmClientes();
            AbmClientes.Show();
        }

        private void controlDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }

        private void gestiónDeAbonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionAbono GestionAbono = new frmGestionAbono();
            GestionAbono.Show();
        }

        private void administraciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmProductos AbmProductos = new frmAdmProductos();
            AbmProductos.Show();
        }

        private void ventaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos.frmVenta Venta = new Productos.frmVenta();
            Venta.Show();
        }

        private void administraciónDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionClases GestionClases = new frmGestionClases();
            GestionClases.Show();
        }

        private void frmMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gestiónDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRolBloq RolBloq = new frmRolBloq();
            RolBloq.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmContaduria contaduria = new frmContaduria();
            contaduria.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("Login");
        }
        private void MostrarBitacora()
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.MostrarBit();    
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            lblBitacora.Visible = false;
            dtgAdmin.Visible = false;
            btnX.Visible = false;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("ABM Clientes");
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("ABM Usuarios");
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("Reposición Stock");
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("Ingreso de Clientes");
        }
        private void rolesYBloqueosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitOrigen("Roles y Bloqueos");
        }

        private void ingresoExitosoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitEvento("Ingreso Exitoso");
        }
        private void ingresoDenegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitEvento("Ingreso Denegado");
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgON();
            CN_clsBitacora objeto = new CN_clsBitacora();
            dtgAdmin.DataSource = objeto.FiltBitEvento("Cambio de Contraseña");
        }

        private void respaldarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rut = new FolderBrowserDialog();
            DialogResult result = rut.ShowDialog();
            if(result == DialogResult.OK)
            {
                string ruta = rut.SelectedPath;
                string rutaNombre = ruta + "\\gimnasio_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "." + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".bak";
                objetoCN.Backup(rutaNombre);
                MessageBox.Show("Respaldo de BD REALIZADO");
            }
            else
            {
                return;
            }
            
        }

        private void restaurarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog rut = new OpenFileDialog();
            DialogResult result = rut.ShowDialog();
            if (result == DialogResult.OK)
            {
                objetoCN.Restore(rut.FileName);
                MessageBox.Show("Respaldo de BD RESTAURADO");
            }
            else
            {
                return;
            }
        }
        private void InglesMenu()
        {
            clientesToolStripMenuItem.Text = "Clients";
            administraciónDeClientesToolStripMenuItem.Text = "Client Management";
            controlDeIngresoToolStripMenuItem.Text = "Entrance control";
            gestiónDeAbonoToolStripMenuItem.Text = "Subscription management";
            administraciónDeClasesToolStripMenuItem.Text = "Class Administration";
            productosToolStripMenuItem.Text = "Products";
            administraciónDeProductosToolStripMenuItem.Text = "Product Management";
            ventaDeProductosToolStripMenuItem.Text = "Sale of products";
            administraciónDeUsuariosToolStripMenuItem.Text = "Employee and user management";
            administraciónDeTurnosToolStripMenuItem.Text = "Shift management";
            usuariosToolStripMenuItem.Text = "Manage payroll";
            gestiónDePermisosToolStripMenuItem.Text = "Roles and blockages";
            clasesToolStripMenuItem.Text = "Classes";
            turnosToolStripMenuItem.Text = "Shifts";
            reportesToolStripMenuItem1.Text = "Reports";
            respaldoToolStripMenuItem.Text = "Backup";
            respaldarBDToolStripMenuItem.Text = "Database Backup";
            restaurarBDToolStripMenuItem.Text = "Database Restore";
            contaduriaToolStripMenuItem1.Text = "Accounting";
            bitacoraToolStripMenuItem1.Text = "System log";
            ingresoToolStripMenuItem.Text = "Customer revenue";
            loginToolStripMenuItem.Text = "Login";
            ingresoExitosoToolStripMenuItem.Text = "Successful entry";
            ingresoDenegadoToolStripMenuItem.Text = "Denied entry";
            cambioDeContraseñaToolStripMenuItem.Text = "Password change";
            reposiciónStockToolStripMenuItem.Text = "Stock replenishment";
            abmClientesToolStripMenuItem2.Text = "AMD Clients";
            usuariosToolStripMenuItem2.Text = "AMD Users";
            rolesYBloqueosToolStripMenuItem.Text = "Roles and blockages";
            ayudaToolStripMenuItem1.Text = "Help";
            manualDeUsuarioToolStripMenuItem.Text = "User Manual";
            acercaDeToolStripMenuItem.Text = "About us";
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAcerca Acerca = new frmAcerca();
            Acerca.Show();
        }
    }
}
