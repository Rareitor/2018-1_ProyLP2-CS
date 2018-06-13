using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmVisualizarComboProductos : Form
    {
        DateTime fecha;
        ComboBL logicaCombo = new ComboBL();
        ComboProducto objetoSeleccionado = new ComboProducto();
        List<ComboProducto> lista;
        SortableBindingList<ComboProducto> listaOrdenada;
        SortableBindingList<ComboProducto> listaFiltrada;

        public FrmVisualizarComboProductos(DateTime fechaVenta)
        {
            InitializeComponent();
            fecha = fechaVenta;
            cbCampo.Text = "<Todos>";
        }

        public FrmVisualizarComboProductos()
        {
            InitializeComponent();
            fecha = DateTime.Now;
            cbCampo.Text = "<Todos>";
        }

        public ComboProducto ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void FrmVisualizarComboProductos_Load(object sender, EventArgs e)
        {
            int mes = fecha.Month;
            int year = fecha.Year;
            string fePeriodo = "";
            if (mes <= 9)
            {
                fePeriodo = year.ToString() + "0" + mes.ToString();
                
            } else
            {
                fePeriodo = year.ToString() + mes.ToString();
            }

            lista = logicaCombo.listarComboProductos(fePeriodo);
            listaOrdenada = new SortableBindingList<ComboProducto>(lista);

            dgvComboProducto.AutoGenerateColumns = false;
            dgvComboProducto.DataSource = lista;

            foreach (DataGridViewColumn column in dgvComboProducto.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            objetoSeleccionado = (ComboProducto) dgvComboProducto.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvComboProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvComboProducto.Sort(dgvComboProducto.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            string campo = cbCampo.Text;
            string filtro = txtFiltro.Text.ToLower();
            listaFiltrada = new SortableBindingList<ComboProducto>();
            foreach (ComboProducto combo in listaOrdenada)
            {
                string nombreProdMin = combo.NombreProducto.ToLower();
                string nombreCanalMin = combo.NombreCanal.ToLower();
                string nombreComboMin = combo.NombreCombo.ToLower();

                if ((campo.Equals("<Todos>") && (nombreProdMin.Contains(filtro) || nombreCanalMin.Contains(filtro) || nombreComboMin.Contains(filtro)))
                    || campo.Equals("Producto") && nombreProdMin.Contains(filtro)
                    || campo.Equals("Canal") && nombreCanalMin.Contains(filtro)
                    || campo.Equals("Combo") && nombreComboMin.Contains(filtro))
                {
                    listaFiltrada.Add(combo);
                }
            }
            dgvComboProducto.DataSource = listaFiltrada;
            dgvComboProducto.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Visible = false;
        }
    }
}
