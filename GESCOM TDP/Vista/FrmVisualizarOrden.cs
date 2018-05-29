using Controlador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Otros
{
    public partial class FrmVisualizarOrden : Form
    {
        private OrdenBL logicaNegocio;
        BindingList<Orden> listaOrdenes;
        SortableBindingList<Orden> listaOrdenada;
        private string puesto;
        private string idPayee;

        public FrmVisualizarOrden(string puesto, string idPayee)
        {
            InitializeComponent();
            cbCampo.Text = "<Todos>";
            this.puesto = puesto;
            this.idPayee = idPayee;
            logicaNegocio = new OrdenBL();
            listaOrdenes = new BindingList<Orden>();
            dgvRecord.AutoGenerateColumns = false;

            listaOrdenada = new SortableBindingList<Orden>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewColumn column in dgvRecord.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            buscar();
            popularListaOrdenada();
            filtrar();
        }

        private void popularListaOrdenada()
        {
            foreach (Orden orden in listaOrdenes)
            {
                listaOrdenada.Add(orden);
            }
        }

        private void filtrar()
        {
            SortableBindingList<Orden> listaAux = new SortableBindingList<Orden>();
            string filtro = cbCampo.Text;
            string field = tbFiltro.Text;


            Boolean cumple = false;
            Double monto = 0.0;
            foreach (Orden orden in listaOrdenada)
            {
                switch (filtro)
                {
                    case "<Todos>":
                        cumple = orden.Id.Contains(field)
                                || orden.NombreTrabajadorCompleto.Contains(field)
                                || orden.NombreProducto.Contains(field)
                                || orden.NombreCanal.Contains(field)
                                || orden.Distrito.Contains(field);
                        break;
                    case "Comisionista":
                        cumple = orden.NombreTrabajadorCompleto.Contains(field);
                        break;
                    case "Producto":
                        cumple = orden.NombreProducto.Contains(field);
                        break;
                    case "Canal":
                        cumple = orden.NombreCanal.Contains(field);
                        break;
                    case "Distrito":
                        cumple = orden.Distrito.Contains(field);
                        break;
                    default:
                        cumple = true;
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(orden);
                monto += orden.Monto;
            }
            dgvRecord.DataSource = listaAux;
            dgvRecord.Refresh();
            textBoxTotal.Text = monto.ToString("0.00");
        }

        private void buscar()
        {
            DateTime fecha1 = dtpFechaInicio.Value;
            DateTime fecha2 = dtpFechaFin.Value;
            Double subtotal;
            switch (puesto)
            {
                case "Comisionista":
                    listaOrdenes = logicaNegocio.listarOrdenesComisionista(this.idPayee, fecha1, fecha2);
                    break;
                case "Jefe":
                    listaOrdenes = logicaNegocio.listarOrdenesJefe(this.idPayee, fecha1, fecha2);
                    break;
                default:
                    listaOrdenes = logicaNegocio.listarOrdenesGerente(fecha1, fecha2);
                    break;
            }
            subtotal = listaOrdenes.Sum(Orden => Orden.Monto);
            textBoxTotal.Text = subtotal.ToString();
            cbCampo.Enabled = true;
            tbFiltro.Enabled = true;
            buttonBuscar.Enabled = true;
        }

        private void dgvRecord_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRecord.Sort(dgvRecord.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (rbnExcel.Checked == true)
            {
                ExportarDataGridViewExcel(dgvRecord);
            } else if (rbnPdf.Checked == true){
                ExportarDataGridViewPdf(dgvRecord);
            }
            
        }


        //Función que genera el documento Pdf 
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dgvRecord.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf  
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvRecord);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF 
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES 
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO 
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF  
            for (int i = 0; i < dgvRecord.ColumnCount; i++)
            {

                objP = new Phrase(dgvRecord.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF 
            for (int i = 0; i < dgvRecord.RowCount-1; i++)
            {
                for (int j = 0; j < dgvRecord.ColumnCount; j++)
                {
                    objP = new Phrase(dgvRecord[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            
            document.Add(datatable);
        }
        
        //Función que obtiene los tamaños de las columnas del datagridview 
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas 
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna 
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void ExportarDataGridViewPdf(DataGridView dgvRecord)
        {
            if (dgvRecord.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {    //ESCOJE A RUTA DONDE GUARDAREMOS EL PDF 
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                    Chunk encab = new Chunk("REPORTE", FontFactory.GetFont("COURIER", 18));
                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(encab));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
