using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {

        }
    }
}
