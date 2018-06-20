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
        SortableBindingList<Orden> lista;
        private string puesto;
        private string idPayee;
        Double subtotal;
        public FrmVisualizarOrden(string puesto, string idPayee)
        {
            InitializeComponent();
            cbCampo.Text = "<Todos>";
            if (dgvRecord.RowCount == 1)
            {
                btnExportar.Enabled = false;
            }
            else
            {
                btnExportar.Enabled = true;
            }

            this.puesto = puesto;
            this.idPayee = idPayee;
            logicaNegocio = new OrdenBL();
            dgvRecord.AutoGenerateColumns = false;

            lista = new SortableBindingList<Orden>();
            foreach (DataGridViewColumn column in dgvRecord.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
            if (dgvRecord.RowCount == 1)
            {
                btnExportar.Enabled = false;
            }
            else
            {
                btnExportar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            filtrar();

            if (dgvRecord.RowCount == 1)
            {
                btnExportar.Enabled = false;
            }
            else
            {
                btnExportar.Enabled = true;
            }
        }

        private void filtrar()
        {
            if (lista == null) return;
            SortableBindingList<Orden> listaAux = new SortableBindingList<Orden>();
            string filtro = cbCampo.Text;
            string field = tbFiltro.Text.ToLower();


            Boolean cumple = false;
            Double monto = 0.0;
            foreach (Orden orden in lista)
            {
                string nombreMin = orden.NombreTrabajadorCompleto.ToLower();
                string nombreProdMin = orden.NombreProducto.ToLower();
                string nombreCanalMin = orden.NombreCanal.ToLower();
                string distritoMin = orden.Distrito.ToLower();
                string idjefeMin = orden.Trabajador.Superior.ToLower();
                switch (filtro)
                {
                    case "<Todos>":
                        cumple = orden.Id.Contains(field)
                                || nombreMin.Contains(field)
                                || nombreProdMin.Contains(field)
                                || nombreCanalMin.Contains(field)
                                || distritoMin.Contains(field)
                                || idjefeMin.Contains(field);
                        break;
                    case "Comisionista":
                        cumple = nombreMin.Contains(field);
                        break;
                    case "ID_Jefe":
                        cumple = idjefeMin.Contains(field);
                        break;
                    case "Producto":
                        cumple = nombreProdMin.Contains(field);
                        break;
                    case "Canal":
                        cumple = nombreCanalMin.Contains(field);
                        break;
                    case "Distrito":
                        cumple = distritoMin.Contains(field);
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
            BindingList<Orden> listaAux;

            switch (puesto)
            {
                case "Gerente":
                    listaAux = logicaNegocio.listarOrdenesGerente(this.idPayee, fecha1, fecha2);
                    break;
                case "Comisionista":
                    listaAux = logicaNegocio.listarOrdenesComisionista(this.idPayee, fecha1, fecha2);
                    break;
                case "Jefe":
                    listaAux = logicaNegocio.listarOrdenesJefe(this.idPayee, fecha1, fecha2);
                    break;
                default:
                    listaAux = new BindingList<Orden>();
                    break;
            }
            subtotal = listaAux.Sum(Orden => Orden.Monto);
            textBoxTotal.Text = subtotal.ToString();
            cbCampo.Enabled = true;
            tbFiltro.Enabled = true;
            lista = new SortableBindingList<Orden>(listaAux);
            dgvRecord.DataSource = lista;
            tbFiltro.Text = "";
            //buttonBuscar.Enabled = true;
        }

        private void dgvRecord_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRecord.Sort(dgvRecord.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (rbnExcel.Checked == true)
            {
                ExportarExcel excel = new ExportarExcel(dgvRecord);
                excel.GenerarExcel();
                MessageBox.Show("Se ha generado correctamente el archivo excel");
            } else if (rbnPdf.Checked == true){
                ExportarPdf pdf = new ExportarPdf(dgvRecord,subtotal);
                pdf.ExportarDataGridViewPdf();
                MessageBox.Show("Se ha generado correctamente el archivo pdf");
            }
            
        }

        private void FrmVisualizarOrden_Load(object sender, EventArgs e)
        {

        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
