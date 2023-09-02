using System;
using CapaPresentacion.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmIdioma : Form
    {
        public frmIdioma()
        {
            InitializeComponent();
        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = "es-AR";
            Settings.Default.Save();
            Idioma.CargarIdioma(this.Controls, this);
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = "en-US";
            Settings.Default.Save();
            Idioma.CargarIdioma(this.Controls, this);
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
