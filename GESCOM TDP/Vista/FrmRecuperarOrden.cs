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
    public partial class FrmRecuperarOrden : Form
    {
        private OrdenBL logicaNegocio;
        private SortableBindingList<Orden> lista;
        public FrmRecuperarOrden()
        {
            InitializeComponent();
            CenterToScreen();
            logicaNegocio = new OrdenBL();
            dgvOrden.AutoGenerateColumns = false;
            BindingList<Orden> listaAux = logicaNegocio.listarOrdenPapelera();
            this.lista = new SortableBindingList<Orden>(listaAux);
            dgvOrden.DataSource = this.lista;
            dgvOrden.ReadOnly = true;
            dgvOrden.AllowUserToAddRows = false;
            if (dgvOrden.Rows.Count == 0)
            {
                btnSeleccionar.Enabled = false;
                btnSeleccionar.BackColor = System.Drawing.Color.White;
                MessageBox.Show("No hay órdenes por restaurar.","Restaurar Órdenes",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            cmbCampo.Text = "<Todos>";
            foreach (DataGridViewColumn column in dgvOrden.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in this.dgvOrden.SelectedRows)
            {
                Orden ord = (Orden)fila.DataBoundItem;
                logicaNegocio.recuperarOrden(ord);
                dgvOrden.Rows.RemoveAt(fila.Index);
            }
        }

        private void FrmRecuperarOrden_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrden_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvOrden.Sort(dgvOrden.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void filtrar()
        {
            if (lista == null) return;
            SortableBindingList<Orden> listaAux = new SortableBindingList<Orden>();
            string filtro = cmbCampo.Text;
            string field = txtDato.Text.ToLower();


            Boolean cumple = false;
            foreach (Orden orden in lista)
            {
                string idMin = orden.Id.ToLower();
                string nombreMin = orden.IdComisionista.ToLower();
                string nombreProdMin = orden.NombreProducto.ToLower();
                string nombreCanalMin = orden.NombreCanal.ToLower();

                switch (filtro)
                {
                    case "<Todos>":
                        cumple = orden.Id.Contains(field)
                                || nombreMin.Contains(field)
                                || nombreProdMin.Contains(field)
                                || nombreCanalMin.Contains(field);
                        break;
                    case "Comisionista":
                        cumple = nombreMin.Contains(field);
                        break;
                    case "Producto":
                        cumple = nombreProdMin.Contains(field);
                        break;
                    case "Canal":
                        cumple = nombreCanalMin.Contains(field);
                        break;
                    case "ID":
                        cumple = idMin.Contains(field);
                        break;
                    default:
                        cumple = true;
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(orden);
            }
            dgvOrden.DataSource = listaAux;
            dgvOrden.Refresh();
        }

        private void txtDato_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }

}
