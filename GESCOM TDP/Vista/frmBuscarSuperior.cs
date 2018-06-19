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
    public partial class frmBuscarSuperior : Form
    {
        private string tipoUsuBus = "";
        private  TrabajadorBL logicaTrabajador = new TrabajadorBL();
        private Trabajador objetoSeleccionado;
        private SortableBindingList<Trabajador> lista;

        public frmBuscarSuperior(string tipoUsu)
        {
            InitializeComponent();
            BindingList<Trabajador> listaTrabajador = new BindingList<Trabajador>();
            tipoUsuBus = tipoUsu;
            if (tipoUsuBus == "GERENTE"){
                listaTrabajador = logicaTrabajador.listarGerentes();
            } else if(tipoUsuBus == "JEFE")
            {
                listaTrabajador = logicaTrabajador.listarJefes();
            } else if (tipoUsu == "COMISIONISTA")
            {
                listaTrabajador = logicaTrabajador.listarComisionistas();
            }
            lista = new SortableBindingList<Trabajador>(listaTrabajador);
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = lista;

            cmbCampo.Text = "<Todos>";
            foreach (DataGridViewColumn column in dgvBusqueda.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        public Trabajador ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void pnlBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjetoSeleccionado = (Trabajador)dgvBusqueda.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void filtrar()
        {
            if (lista == null) return;
            string campo = cmbCampo.Text;
            string filtro = txtDato.Text.ToLower();
            SortableBindingList<Trabajador> listaFiltrada = new SortableBindingList<Trabajador>();
            bool cumple;
            foreach (Trabajador trabajador in lista)
            {
                string nombreMin = trabajador.Nombre.ToLower();
                string apellidoPatMin = trabajador.ApellidoPaterno.ToLower();
                string apellidoMatMin = trabajador.ApellidoMaterno.ToLower();
                string emailMin = trabajador.Email.ToLower();
                string idMin = trabajador.IdTrabajador.ToLower();
                switch (campo)
                {
                    case "<Todos>":
                        cumple = idMin.Contains(filtro)
                                || trabajador.Dni.Contains(filtro)
                                || nombreMin.Contains(filtro)
                                || apellidoPatMin.Contains(filtro)
                                || apellidoMatMin.Contains(filtro)
                                || emailMin.Contains(filtro);
                        break;
                    case "ID":
                        cumple = idMin.Contains(filtro);
                        break;
                    case "DNI":
                        cumple = trabajador.Dni.Contains(filtro);
                        break;
                    case "Nombre":
                        cumple = nombreMin.Contains(filtro);
                        break;
                    case "Apellido Paterno":
                        cumple = apellidoPatMin.Contains(filtro);
                        break;
                    case "Apellido Materno":
                        cumple = apellidoMatMin.Contains(filtro);
                        break;
                    case "Email":
                        cumple = emailMin.Contains(filtro);
                        break;
                    default:
                        cumple = false;
                        break;
                }
                if (!cumple) continue;
                listaFiltrada.Add(trabajador);
            }
            dgvBusqueda.DataSource = listaFiltrada;
            dgvBusqueda.Refresh();
        }

        private void dgvBusqueda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBusqueda.Sort(dgvBusqueda.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
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
