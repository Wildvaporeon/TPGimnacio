using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmAdmProductos : Form
    {
        #region Atributos
        // Creo e instancio la lista de clases
        private List<CapaNegocio.Productos> productos = new List<CapaNegocio.Productos>();
        CapaNegocio.Productos objetoCN = new CapaNegocio.Productos();
        private string idProducto = null;
        private bool Editar = false;
        // Variable global para guardar el indice del producto seleccionado
        private int id;
        #endregion

        #region Eventos
        public frmAdmProductos()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmAdmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {

            CapaNegocio.Productos objeto = new CapaNegocio.Productos();
            dtgProductos.DataSource = objeto.MostrarProd();
        }
        private void BuscarProducto()
        {
            CapaNegocio.Productos objeto = new CapaNegocio.Productos();
            dtgProductos.DataSource = objeto.BuscarProd(txtBuscarProd.Text);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtTipo.Clear();
            
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            Editar = false;
            MostrarProductos();
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
            {
                btnGuardar.Text = "Save";
            }
            else
            {
                btnGuardar.Text = "Guardar";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Verifico que el valor del txtPrecio sea numerico
            if (!isNumeric(txtPrecio.Text))
            {
                mensajeError(txtPrecio);
                return;
            }
            // Verifico que el valor del txtStock sea numerico
            if (!isNumeric(txtStock.Text))
            {
                mensajeError(txtStock);
                return;
            }

            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtPrecio.Text, txtTipo.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarProductos();
                    limpiarForm();
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
                    objetoCN.EditarProd(txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtPrecio.Text, txtTipo.Text, idProducto);
                    MessageBox.Show("Se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
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
                
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminación de Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    idProducto = dtgProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
                    objetoCN.EliminarProd(idProducto);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarProductos();
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
            /* Cargo en los TextBox's correspondientes lo guardado en la lista de la fila seleccionada
             * de la grilla (utilizando el valor guardado en la variable global "id") 
             */
            if (dtgProductos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dtgProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
                txtDescripcion.Text = dtgProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtStock.Text = dtgProductos.CurrentRow.Cells["Stock"].Value.ToString();
                txtPrecio.Text = dtgProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtTipo.Text = dtgProductos.CurrentRow.Cells["Tipo"].Value.ToString();
                idProducto = dtgProductos.CurrentRow.Cells["IdProducto"].Value.ToString();
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

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtgProductos.CurrentCell.RowIndex; // Guardo el Indice de la celda seleccionada en la variable global
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e); // Permito escribir solo numeros
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e); // Permito escribir solo numeros
        }
        #endregion

        #region Metodos

        // Metodo de mensaje de error
        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Guardar: \n Debe completar los campos obligatorios",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            control.Focus();
        }

        // Metodo para actualizar la grilla (DataGridView)
        private void actualizarDatos()
        {
           dtgProductos.DataSource = null;      // Limpio la grilla
           dtgProductos.DataSource = productos; // Vuelvo a cargar la grilla
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


    }
}
