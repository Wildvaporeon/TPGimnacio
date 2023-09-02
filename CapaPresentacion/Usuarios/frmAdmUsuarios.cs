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
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion.Usuarios
{
    public partial class frmAdmUsuarios : Form
    {
        clsEmpleados objetoCN = new clsEmpleados(); 

        private string IdEmpleado = null;
        private bool Editar = false;
        private int id;

        public frmAdmUsuarios()
        {
            InitializeComponent();
            //Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmAdmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            
        }
        private void MostrarEmpleados()
        {
            clsEmpleados objeto = new clsEmpleados();
            dtgEmpleados.DataSource = objeto.MostrarEmp();
            ColumnasEmpleados();
        }
        private void ColumnasEmpleados()
        {
            dtgEmpleados.Columns["Nombre"].Visible = true;
            dtgEmpleados.Columns["Apellido"].Visible = true;
            dtgEmpleados.Columns["IdEmpleado"].DisplayIndex = 0;
            dtgEmpleados.Columns["Nombre"].DisplayIndex = 1;
            dtgEmpleados.Columns["Apellido"].DisplayIndex = 2;
        }
        private void ColumnasUsuarios()
        {
            dtgEmpleados.Columns["IdUsuario"].DisplayIndex = 0;
            dtgEmpleados.Columns["Usuario"].DisplayIndex = 1;
            dtgEmpleados.Columns["Contraseña"].Visible = false;
            dtgEmpleados.Columns["Nombre"].DisplayIndex = 2;
            dtgEmpleados.Columns["Apellido"].DisplayIndex = 3;
            dtgEmpleados.Columns["IdEmpleado"].DisplayIndex = 4;
            dtgEmpleados.Columns["IdRol"].DisplayIndex = 5;
        }
        private void MostrarUsuarios()
        {
            
            clsEmpleados objeto = new clsEmpleados();
            dtgEmpleados.DataSource = objeto.MostrarUs();
            ColumnasUsuarios();
        }


        private void BuscarEmpleadoCuil(string cuil)
        {
            clsEmpleados objeto = new clsEmpleados();
            dtgEmpleados.DataSource = objeto.BuscarEmpCuil(cuil);
        }

        private void BuscarEmpleadoId(int id)
        {
            clsEmpleados objeto = new clsEmpleados();
            dtgEmpleados.DataSource = objeto.BuscarEmp(id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!isNumeric(txtCel.Text) || txtCel.TextLength > 10)
            {
                mensajeError(txtCel);
                return;
            }

            if (!isNumeric(txtTelefono.Text) || txtTelefono.TextLength > 10)
            {
                mensajeError(txtTelefono);
                return;
            }
            if (txtEmail.ForeColor == Color.Red)
            {
                mensajeError(txtEmail);
                return;
            }

            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarEmp(txtNombres.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text, txtCuil.Text, dttFechaNac.Value, txtGenero.Text, Convert.ToInt32(txtCel.Text), Convert.ToInt32(txtTelefono.Text), txtEmail.Text, txtSector.Text);
                    CN_clsBitacora Guardar = new CN_clsBitacora("Alta Empleado", "Nivel Medio", "ABM Usuarios");
                    MessageBox.Show("Se inserto correctamente");
                    MostrarEmpleados();
                    LimpiarControles(this);
                    PintarBoton();
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
                    objetoCN.EditarEmp(txtNombres.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text, txtCuil.Text, dttFechaNac.Value, txtGenero.Text, Convert.ToInt32(txtCel.Text), Convert.ToInt32(txtTelefono.Text), txtEmail.Text, txtSector.Text, IdEmpleado);
                    CN_clsBitacora Guardar = new CN_clsBitacora("Empleado Modificado", "Nivel Medio", "ABM Usuarios");
                    MessageBox.Show("Se edito correctamente");
                    MostrarEmpleados();
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
                    PintarBoton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgEmpleados.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNombres.Text = dtgEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dtgEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dtgEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                txtLocalidad.Text = dtgEmpleados.CurrentRow.Cells["Localidad"].Value.ToString();
                txtProvincia.Text = dtgEmpleados.CurrentRow.Cells["Provincia"].Value.ToString();
                txtCuil.Text = dtgEmpleados.CurrentRow.Cells["Cuil"].Value.ToString();
                dttFechaNac.Text = dtgEmpleados.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString();
                txtGenero.Text = dtgEmpleados.CurrentRow.Cells["Genero"].Value.ToString();
                txtCel.Text = dtgEmpleados.CurrentRow.Cells["Celular"].Value.ToString();
                txtTelefono.Text = dtgEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dtgEmpleados.CurrentRow.Cells["Email"].Value.ToString();
                txtSector.Text = dtgEmpleados.CurrentRow.Cells["Sector"].Value.ToString();
                IdEmpleado = dtgEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminación de Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    IdEmpleado = dtgEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    objetoCN.EliminarEmp(IdEmpleado);
                    CN_clsBitacora Guardar = new CN_clsBitacora("Baja Empleado", "Nivel Alto", "ABM Usuarios");
                    MessageBox.Show("Eliminado correctamente");
                    MostrarEmpleados();
                    LimpiarControles(this);
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
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!isNumeric(txtBuscarId.Text))
                {
                    MostrarEmpleados();
                    //dtgEmpleados.DataSource = dt;
                }
                BuscarEmpleadoId(Convert.ToInt32(txtBuscarId.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCuil_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {

                BuscarEmpleadoCuil(txtBuscarCuil.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un CUIL valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            grpLogin.Enabled = false;
            lblIdEmpleado.Text = "ID: ";
            Editar = false;
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
            {
                btnGuardar.Text = "Save";
            }
            else
            {
                btnGuardar.Text = "Guardar";
            }
            MostrarEmpleados();
            PintarBoton();
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
        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Guardar: " + control.Text + "\n No es un dato valido",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            control.Focus();
        }

        private void dtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtgEmpleados.CurrentCell.RowIndex; // Guardo el Indice de la celda seleccionada en la variable global
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if(dtgEmpleados.CurrentCell.RowIndex!=-1)
                {

                    CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbRol, "Roles", "IdRol", "Rol");
                    cmbRol.Visible = true;
                    lblRol.Visible = true;
                    txtUsuario.Enabled = true;
                    id = Convert.ToInt32(dtgEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                    lblIdEmpleado.Text = "ID Seleccionado: " + id;
                    if (grpLogin.Enabled == false)
                        {
                            grpLogin.Enabled = true;
                        }
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un CUIL valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (dtgEmpleados.CurrentCell.RowIndex != -1)
                {
                    if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "en-US")
                    {
                        btnGuardar.Text = "Save changes";
                    }
                    else
                    {
                        btnGuardar.Text = "Guardar Cambios";
                    }
                    cmbRol.Visible = false;
                    lblRol.Visible = false;
                    txtUsuario.Enabled = false;
                    id = Convert.ToInt32(dtgEmpleados.CurrentRow.Cells["IdUsuario"].Value.ToString());
                    lblIdEmpleado.Text = "ID Seleccionado: " + id;
                    txtUsuario.Text = dtgEmpleados.CurrentRow.Cells["Usuario"].Value.ToString();
                    if (grpLogin.Enabled == false)
                    {
                        grpLogin.Enabled = true;
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int IdRol;
            if (btnAceptar.Text == "Aceptar")
            {
              try
                {
                    if (txtPass.Text != txtPassConfirm.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(txtUsuario.Text.Length==0)
                    {
                        MessageBox.Show("Debe colocar un nombre de usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (UsuarioEnUso(txtUsuario.Text)==1)
                    {
                        MessageBox.Show("El nombre de usuario ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmbRol.ValueMember = "IdRol";

                        IdRol = Convert.ToInt32(cmbRol.SelectedValue.ToString());

                        objetoCN.InsertarUs(id, dtgEmpleados.CurrentRow.Cells["Nombre"].Value.ToString(), dtgEmpleados.CurrentRow.Cells["Apellido"].Value.ToString(), txtUsuario.Text, clsEncriptación.SHA256(txtPass.Text), IdRol, false);
                        LimpiarControles(this);
                        lblIdEmpleado.Text = "ID:";
                        grpLogin.Enabled = false;
                        MessageBox.Show("Creado Exitosamento");
                        CN_clsBitacora Guardar = new CN_clsBitacora("Alta Usuario", "Nivel Alto", "ABM Usuarios");
                    }
                
                }

                catch (Exception)
                {
                    MessageBox.Show("Error al generar usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (btnAceptar.Text == "Guardar Cambios"|| btnAceptar.Text == "Save changes")
            {
                try
                {
                    if (txtPass.Text != txtPassConfirm.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objetoCN.EditarUs(id, txtUsuario.Text, clsEncriptación.SHA256(txtPass.Text), Convert.ToInt32(dtgEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString()));
                        LimpiarControles(this);
                        lblIdEmpleado.Text = "ID:";
                        grpLogin.Enabled = false;
                        MostrarUsuarios();
                        MessageBox.Show("Editado correctamente");
                        CN_clsBitacora Guardar = new CN_clsBitacora("Modificación Usuario", "Nivel Medio", "ABM Usuarios");
                    }
                    btnAceptar.Text = "Aceptar";
                }

                catch (Exception)
                {
                    MessageBox.Show("Error al generar usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void btnMostrarUs_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void btnEliminarUs_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "Eliminación de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    IdEmpleado = dtgEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    objetoCN.EliminarUs(IdEmpleado);
                    MessageBox.Show("Eliminado correctamente");
                    CN_clsBitacora Guardar = new CN_clsBitacora("Baja Usuario", "Nivel Alto", "ABM Usuarios");
                    MostrarUsuarios();
                    LimpiarControles(this);
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

        public int UsuarioEnUso(string usuario)
        {

            DataTable DT = new DataTable();

            DT = objetoCN.ConsultarUs(usuario);
            
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    string Usuario = row[0].ToString();

                }
                DT.Rows.Clear();
                return 1;
            }
            else
            {
                DT.Rows.Clear();
                return 0;
            }
        }


        private void PintarBoton()
        {
            if(txtApellido.Text.Length !=0 && txtNombres.Text.Length != 0 && txtCuil.Text.Length != 0 && txtCel.Text.Length != 0&& txtTelefono.Text.Length!=0)
            {
               btnGuardar.BackColor = Color.Green;
               btnGuardar.ForeColor = Color.White;
            }
            else
            {
               btnGuardar.BackColor = Color.White;
               btnGuardar.ForeColor = Color.Black;
            }
        }


        private void txtCel_Leave_1(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtCuil_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtProvincia_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }

        private void txtSector_Leave(object sender, EventArgs e)
        {
            PintarBoton();
        }
    }
}
