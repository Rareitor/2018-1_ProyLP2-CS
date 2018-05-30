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

namespace Vista.Otros
{
    public partial class FrmVisualizarCanalVenta : Form
    {
        private CanalBL logicaNegocio;
        private SortableBindingList<Canal> listaOriginal;
        public FrmVisualizarCanalVenta()
        {
            InitializeComponent();
            logicaNegocio = new CanalBL();
            BindingList<Canal> lista = logicaNegocio.listarCanal();
            listaOriginal = new SortableBindingList<Canal>(lista);
            dgvCanalVenta.AutoGenerateColumns = false;
            dgvCanalVenta.DataSource = listaOriginal;
            foreach (DataGridViewColumn column in dgvCanalVenta.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            string filtro = textBox1.Text;
            SortableBindingList<Canal> listaFiltrada = new SortableBindingList<Canal>();
            foreach (Canal canal in listaOriginal)
            {
                if (canal.Nombre.ToUpper().Contains(filtro.ToUpper()))
                {
                    listaFiltrada.Add(canal);
                }
            }
            dgvCanalVenta.DataSource = listaFiltrada;
            dgvCanalVenta.Refresh();
        }

        private void dgvCanalVenta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCanalVenta.Sort(dgvCanalVenta.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
