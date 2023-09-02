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
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmRolBloq : Form
    {
        int id;
        clsEmpleados objetoCN = new clsEmpleados();
        DataTable tabla = new DataTable();
        public frmRolBloq()
        {
            InitializeComponent();
            //Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmRolBloq_Load(object sender, EventArgs e)
        {
            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbRol, "Roles", "IdRol", "Rol");
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {

            clsEmpleados objeto = new clsEmpleados();
            dtgRolBloq.DataSource = objeto.MostrarUs();
            ColumnasUsuarios();
        }
        private void ColumnasUsuarios()
        {
            dtgRolBloq.Columns["IdUsuario"].DisplayIndex = 0;
            dtgRolBloq.Columns["Usuario"].DisplayIndex = 1;
            dtgRolBloq.Columns["Contraseña"].Visible = false;
            dtgRolBloq.Columns["Nombre"].Visible = false;
            dtgRolBloq.Columns["Apellido"].DisplayIndex = 2;
            dtgRolBloq.Columns["IdRol"].DisplayIndex = 3;
            dtgRolBloq.Columns["Activo"].DisplayIndex = 4;
            dtgRolBloq.Columns["IdEmpleado"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgRolBloq.CurrentCell.RowIndex != -1)
                {
                    int IdRol = -1;
                    IdRol = Convert.ToInt32(dtgRolBloq.CurrentRow.Cells["IdRol"].Value.ToString());

                    id = Convert.ToInt32(dtgRolBloq.CurrentRow.Cells["IdUsuario"].Value.ToString());
                    tabla = objetoCN.ConsultarRol(id, IdRol);
                    if (tabla.Rows.Count > 0)
                    {
                        foreach (DataRow row in tabla.Rows)
                        {
                            cmbRol.Text = row[0].ToString();
                        }
                    }
                    lblUsuario.Text = "Usuario seleccionado: " + dtgRolBloq.CurrentRow.Cells["Usuario"].Value.ToString();
                    chcBloqueo.Checked = !Convert.ToBoolean(dtgRolBloq.CurrentRow.Cells["Activo"].Value.ToString());
                    if(chcBloqueo.Checked==true)
                    {
                        chcBloqueo.ForeColor = Color.Orange;
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
            try
            {
                int IdRol=-1;
                cmbRol.ValueMember = "IdRol";
                try
                {
                    IdRol = Convert.ToInt32(cmbRol.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("No seleccionó ningun usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bool activo = !chcBloqueo.Checked;
                objetoCN.EditarRolBloq(id, IdRol, activo);
                MostrarUsuarios();
                LimpiarControles(this);
                lblUsuario.Text = "Usuario seleccionado: ";
                chcBloqueo.Checked = false;
                chcBloqueo.ForeColor = Color.White;
                CN_clsBitacora Guardar = new CN_clsBitacora("Usuario modificado", "Nivel Medio", "Roles y Bloqueos");
            }

            catch (Exception)
            {
                MessageBox.Show("Error al guardar cambios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id = -1;
            LimpiarControles(this);
            lblUsuario.Text = "Usuario seleccionado: ";
            chcBloqueo.Checked = false;
            MostrarUsuarios();
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

        private void chcBloqueo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBloqueo.Checked == true)
            {
                chcBloqueo.ForeColor = Color.Orange;
            }
            else
            {
                chcBloqueo.ForeColor = Color.White;
            }
        }
    }
}
