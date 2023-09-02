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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmContaduria : Form
    {
        DateTime FechaInicio = DateTime.Now.AddDays(-30);
        
        public frmContaduria()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
        }

        private void frmContaduria_Load(object sender, EventArgs e)
        {
            dttInicio.Text = Convert.ToString(FechaInicio);
            
            dtgContaduria.Columns.Add("Origen", "Origen");
            dtgContaduria.Columns.Add("Importe", "Importe");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss"));



                //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
                string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in dtgContaduria.Rows)
                {
                    filas += "<tr>";
                    //filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Origen"].Value.ToString() + "</td>";
                    //filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total += decimal.Parse(row.Cells["Importe"].Value.ToString());
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.banerFac, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);


                        //pdfDoc.Add(new Phrase("Hola Mundo"));
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Documento generado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            /*int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];

            row.Cells["Cantidad"].Value = txtcantidad.Text;
            row.Cells["Descripcion"].Value = txtdescripcion.Text;
            row.Cells["PrecioUnitario"].Value = txtprecio.Text;
            row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContaduria_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmContaduria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserCache.Rol != "Administración")
            {
                Application.Exit();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            clsVentas objetoCN = new clsVentas();
            DT = objetoCN.TotalVent();

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    VentCache.Total = Convert.ToDouble(row[0].ToString());
                }
            }
            dtgContaduria.Rows.Add("Ventas", Convert.ToString(VentCache.Total));
        }

        private void TotalVentas()
        {
            clsVentas objetoCN = new clsVentas();
            dtgContaduria.DataSource = objetoCN.TotalVent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgContaduria.DataSource = null;
        }
    }
}
