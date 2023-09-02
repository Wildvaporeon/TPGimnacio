using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using DataTableExcel = Microsoft.Office.Interop.Excel;

namespace CapaPresentacion
{
    public partial class frmAdmClientes : Form
    {
        #region Atributos
        private List<CapaNegocio.clsClientes> Clientes = new List<CapaNegocio.clsClientes>();
        CapaNegocio.clsClientes objetoCN = new CapaNegocio.clsClientes();

        private string IdCliente = null;
        private bool Editar = false;
        private int id;

        #endregion

        #region Eventos
        public frmAdmClientes()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }
        private void frmAdm_Load(object sender, EventArgs e)
        {   
            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbAbono, "Abono", "IdAbono", "Abono");
            MostrarClientes();
        }
        private void MostrarClientes()
        {

            clsClientes objeto = new clsClientes();
            dtgClientes.DataSource = objeto.MostrarCli();
        }


        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void BuscarClienteDni(int dni)
        {
            clsClientes objeto = new clsClientes();
            dtgClientes.DataSource = objeto.BuscarDoc(dni);
        }

        private void BuscarClienteId(int id)
        {
            clsClientes objeto = new clsClientes();
            dtgClientes.DataSource = objeto.BuscarCli(id);
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult result = fo.ShowDialog();
            if (result == DialogResult.OK)
            {
                pctFoto.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pctFoto.Image = CapaPresentacion.Properties.Resources.silueta;
            LimpiarControles(this);
            Editar = false;
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
            {
                btnGuardar.Text = "Save";
            }
            else
            {
                btnGuardar.Text = "Guardar";
            }
            
            MostrarClientes();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Foto de perfil cliente
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pctFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            if (!isNumeric(txtDni.Text))
            {
                mensajeError(txtDni);
                return;
            }

            if (!isNumeric(txtCel.Text))
            {
                mensajeError(txtCel);
                return;
            }

            if (!isNumeric(txtTelefono.Text))
            {
                mensajeError(txtTelefono);
                return;
            }
            if(txtEmail.ForeColor == Color.Red)
            {
                mensajeError(txtEmail);
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                mensajeError(txtNombre);
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                mensajeError(txtApellido);
                return;
            }

            //INSERTAR
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarCli(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text, Convert.ToInt32(txtDni.Text), dttFechaNac.Value, txtGenero.Text, Convert.ToInt32(txtCel.Text), Convert.ToInt32(txtTelefono.Text), txtEmail.Text, cmbAbono.Text, ms.GetBuffer(), dttAptoFisico.Value);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarClientes();
                    pctFoto.Image = CapaPresentacion.Properties.Resources.silueta;
                    LimpiarControles(this);
                    CN_clsBitacora Guardar = new CN_clsBitacora("Cliente Nuevo", "Nivel Medio", "ABM Clientes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarCli(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text, Convert.ToInt32(txtDni.Text), dttFechaNac.Value, txtGenero.Text, Convert.ToInt32(txtCel.Text), Convert.ToInt32(txtTelefono.Text), txtEmail.Text, cmbAbono.Text, ms.GetBuffer(), IdCliente, dttAptoFisico.Value);
                    MessageBox.Show("Se edito correctamente");
                    MostrarClientes();
                    pctFoto.Image = CapaPresentacion.Properties.Resources.silueta; 
                    LimpiarControles(this);
                    Editar = false;
                    CN_clsBitacora Guardar = new CN_clsBitacora("Cliente Modificado", "Nivel Medio", "ABM Clientes");
                    if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
                    {
                        btnGuardar.Text = "Save";
                    }
                    else
                    {
                        btnGuardar.Text = "Guardar";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminación de Ciente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    IdCliente = dtgClientes.CurrentRow.Cells["IdCliente"].Value.ToString();
                    objetoCN.EliminarCli(IdCliente);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarClientes();
                    pctFoto.Image = CapaPresentacion.Properties.Resources.silueta;
                    LimpiarControles(this);
                    CN_clsBitacora Guardar = new CN_clsBitacora("Cliente eliminado", "Nivel Alto", "ABM Clientes");
                }

                else
                {
                    return;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                Editar = true;
                
                txtNombre.Text = dtgClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dtgClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtLocalidad.Text = dtgClientes.CurrentRow.Cells["Localidad"].Value.ToString();
                txtProvincia.Text = dtgClientes.CurrentRow.Cells["Provincia"].Value.ToString();
                txtDni.Text = dtgClientes.CurrentRow.Cells["Dni"].Value.ToString();
                dttFechaNac.Text = dtgClientes.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString();
                txtGenero.Text = dtgClientes.CurrentRow.Cells["Genero"].Value.ToString();
                txtCel.Text = dtgClientes.CurrentRow.Cells["Celular"].Value.ToString();
                txtTelefono.Text = dtgClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dtgClientes.CurrentRow.Cells["Email"].Value.ToString();
                cmbAbono.Text = dtgClientes.CurrentRow.Cells["Abono"].Value.ToString();
                IdCliente = dtgClientes.CurrentRow.Cells["IdCliente"].Value.ToString();
                dttAptoFisico.Text = dtgClientes.CurrentRow.Cells["AptoFisico"].Value.ToString();
                try
                {
                    DataTable dt = new DataTable();
                    dt = objetoCN.BuscarCli(Convert.ToInt32(IdCliente));
                    byte[] img = (byte[])dt.Rows[0]["Foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    pctFoto.Image = Image.FromStream(ms);
                    dt.Clear();
                }

                catch
                {
                    pctFoto.Image = CapaPresentacion.Properties.Resources.silueta;
                }

                if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
                {
                    btnGuardar.Text = "Save changes";
                }
                else
                {
                    btnGuardar.Text = "Guardar Cambios";
                }
                
            }
            else
                MessageBox.Show("Seleccione una fila por favor");

        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!isNumeric(txtBuscarId.Text))
                {
                    dtgClientes.DataSource = dt;
                }
                BuscarClienteId(Convert.ToInt32(txtBuscarId.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                if (!isNumeric(txtBuscarDni.Text))
                {
                    dtgClientes.DataSource = dt;
                }
                BuscarClienteDni(Convert.ToInt32(txtBuscarDni.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un DNI valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region Metodos

        // Metodo de mensaje de error
        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Guardar: "+control.Name+"\n "+control.Text+"No es un dato valido",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            control.Focus();
        }


        // Metodo para limpiar los campos de un control (por ejemplo un panel)
        private void limpiarCampos(Control control)
        {
            //Recorro los controles del del control recibido por parametro
            foreach (object item in control.Controls)
            {
                // Si el control es un TextBox lo limpio
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        // Metodo para permitir solo ingresar numero o simbolos exceptuados como el "." en este caso
        private KeyPressEventArgs soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) |
                char.ToString(e.KeyChar) == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e;
        }
        // Metodo para validar si un valor dado es numerico o no
        private bool isNumeric(string valor)
        {
            try
            {
                // Si puede convertilo a double devuelve verdadero (es numerico)
                Convert.ToDouble(valor);
                return true;
            }
            catch (Exception)
            {
                // Al no poder convertirse y generarse una excepcion devuelve falso (no es un numero)
                return false;
            }
        }
        #endregion


        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtgClientes.CurrentCell.RowIndex; // Guardo el Indice de la celda seleccionada en la variable global
            pctFoto.Image = CapaPresentacion.Properties.Resources.silueta;
            LimpiarControles(this);
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
            {
                btnGuardar.Text = "Save";
            }
            else
            {
                btnGuardar.Text = "Guardar";
            }
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            clsValidarMail val = new clsValidarMail();
            val.Correo = txtEmail.Text;
            if (val.Valid() != true)
            {
                txtEmail.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
}
