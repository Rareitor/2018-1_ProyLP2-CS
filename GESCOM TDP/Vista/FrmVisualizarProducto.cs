using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Otros
{
    public partial class FrmVisualizarProducto : Form
    {
        private ProductoBL logicaNegocio;
        private SortableBindingList<Producto> listaOriginal;
        private SortableBindingList<Producto> listaFiltrada;
        private bool papelera;

        public bool Papelera { get => papelera; set => papelera = value; }

        public FrmVisualizarProducto()
        {
            InitializeComponent();
            papelera = false;
            logicaNegocio = new ProductoBL();
            listaOriginal = new SortableBindingList<Producto>();
            listaFiltrada = new SortableBindingList<Producto>();
            dgvProducto.AutoGenerateColumns = false;
            btnRecuperar.Visible = false;
            foreach (DataGridViewColumn column in dgvProducto.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        public FrmVisualizarProducto(bool papelera)
        {
            InitializeComponent();
            this.papelera = papelera;
            logicaNegocio = new ProductoBL();
            listaOriginal = new SortableBindingList<Producto>();
            listaFiltrada = new SortableBindingList<Producto>();
            dgvProducto.AutoGenerateColumns = false;
        }

        private void FrmVisualizarProductos_Load(object sender, EventArgs e)
        {
            ThreadStart listarProductos = new ThreadStart(cargarLista);
            Thread hiloProductos = new Thread(listarProductos);
            CheckForIllegalCrossThreadCalls = false;
            hiloProductos.Start();
            agregarComboBox();
            hiloProductos.Join();
        }

        private void agregarComboBox()
        {
            cmbTipoProducto.Items.Add("<Todos>");
            BindingList<String> tipos = logicaNegocio.listarTiposProductos();
            for (int i = 0; i < tipos.Count; i++)
            {
                cmbTipoProducto.Items.Add(tipos[i]);
            }
            cmbTipoProducto.Text = "<Todos>";
        }

        private void cargarLista()
        {
            BindingList<Producto> lista;
            if (papelera)
            {
                lista = logicaNegocio.listarProductosPapelera();
            }
            else
            {
                lista = logicaNegocio.listarProductos();
            }
            listaOriginal = new SortableBindingList<Producto>(lista);
            dgvProducto.DataSource = listaOriginal;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in this.dgvProducto.SelectedRows){
                Producto p = (Producto)fila.DataBoundItem;
                logicaNegocio.recuperarProducto(p);
                dgvProducto.Rows.RemoveAt(fila.Index);
            }
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            string filtro = cmbTipoProducto.Text;
            string filtroNombre = textBox1.Text;
            listaFiltrada = new SortableBindingList<Producto>();
            foreach (Producto producto in listaOriginal)
            {
                if((filtro.Equals("<Todos>") || producto.Tipo == filtro)
                    && producto.Nombre.ToUpper().Contains(filtroNombre.ToUpper()))
                {
                    listaFiltrada.Add(producto);
                }
            }
            dgvProducto.DataSource = listaFiltrada;
            dgvProducto.Refresh();
        }

        private void dgvProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvProducto.Sort(dgvProducto.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }
    }
}
