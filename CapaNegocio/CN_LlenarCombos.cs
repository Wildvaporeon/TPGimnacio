using System.Data;
using CapaDatos;
using System.Windows.Forms;




namespace CapaNegocio

{
    public class CN_LlenarCombos
    {
        private CD_LlenarCombos llenar = new CD_LlenarCombos();

        private string nomtabla;
        private string campoid;
        private string campodescrip;
        private string condicion;

        public string NomTabla
        {
            set { nomtabla = value; }
        }
        public string CampoId
        {
            set { campoid = value; }
        }
        public string CampoDescrip
        {
            set { campodescrip = value; }
        }
        public string Condicion
        {
            set { condicion = value; }
        }

        public DataTable Cargar()
        {
            llenar.Tabla = nomtabla;
            llenar.CampoId = campoid;
            llenar.CampoDescrip = campodescrip;
            llenar.Condicion = condicion;

            DataTable tabla = new DataTable();
            tabla = llenar.CargarCMB();
            return tabla;
        }

        public CN_LlenarCombos(ComboBox CMB, string NombreTabla, string CampoID, string CampoDescrip, string Condicion = "")
        {
            llenar.Tabla = NombreTabla;
            llenar.CampoId = CampoID;
            llenar.CampoDescrip = CampoDescrip;
            llenar.Condicion = Condicion;

            CMB.DataSource = llenar.CargarCMB();

            CMB.DisplayMember = CampoDescrip;
            CMB.ValueMember = CampoID;
            CMB.SelectedIndex = -1;
        }
    }
}
