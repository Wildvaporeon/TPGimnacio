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
    public partial class frmFicha : Form
    {
        string fecha = string.Format("{0:dd/MM/yyyy}", ClientCache.AptoFisico);

        public frmFicha()
        {
            InitializeComponent();
            //Idioma.CargarIdioma(this.Controls, this);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFicha_Load(object sender, EventArgs e)
        {
            lblAbono.Text = ClientCache.Abono;
            lblAptoFisico.Text = fecha.ToString(); 
            byte[] img = ClientCache.Foto;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            pctFicha.Image = Image.FromStream(ms);
            DataTable dt = new DataTable();
            ConsultarCliente(ClientCache.IdCliente);
            int i = DateTime.Compare(DateTime.Now, ClientCache.AptoFisico);
            VerificarAptoFisico(i);
        }
        private void ConsultarCliente(int id)
        {

            clsClientes objeto = new clsClientes();
            dtgFicha.DataSource = objeto.ConsultarCli(id);
        }
        
        private void VerificarAptoFisico(int i)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            if (i >= 1)
            {
                
                lblAptoFisico.Text = fecha.ToString() + " VENCIDO";
                lblAptoFisico.ForeColor = Color.Red;
                lblAptoFisico.BackColor = Color.White;

            }
        }
    }
}
