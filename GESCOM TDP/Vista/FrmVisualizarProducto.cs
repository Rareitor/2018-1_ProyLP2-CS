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
        private BindingList<Producto> listaOriginal;
        private BindingList<Producto> listaFiltrada;
        public FrmVisualizarProducto()
        {
            InitializeComponent();
            logicaNegocio = new ProductoBL();
            listaOriginal = new BindingList<Producto>();
            listaFiltrada = new BindingList<Producto>();
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
            BindingList<String> tipos = logicaNegocio.listarTiposProductos();
            for (int i = 0; i < tipos.Count; i++)
            {
                cmbTipoProducto.Items.Add(tipos[i]);
            }
        }

        private void cargarLista()
        {
            listaOriginal = logicaNegocio.listarProductos();
            dgvProducto.DataSource = listaOriginal;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
