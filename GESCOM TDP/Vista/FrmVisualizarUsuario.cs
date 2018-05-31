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
    public partial class FrmVisualizarUsuario : Form
    {
        private SortableBindingList<Trabajador> listaOriginal;
        private TrabajadorBL logicaNegocio;
        String puesto;
        private Trabajador ObjetoSeleccionado = new Trabajador();

        public Trabajador ObjetoSeleccionado1 { get => ObjetoSeleccionado; set => ObjetoSeleccionado = value; }

        public FrmVisualizarUsuario()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            cmbCampo.Text = "<Todos>";
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        public FrmVisualizarUsuario(String cargoListar, String idPayee, String puesto, int extra)
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            cmbCampo.Text = "<Todos>";
            if (extra == 1)
            {
                btnSeleccionar.Visible = true;
                groupBox1.Visible = false;
            } else
            {
                btnSeleccionar.Visible = false;
                groupBox1.Visible = true;
            }

            this.puesto = puesto;
            logicaNegocio = new TrabajadorBL();
            BindingList<Trabajador> lista = new BindingList<Trabajador>();
            switch (this.puesto)
            {
                case "Administrador":
                    switch (cargoListar)
                    {
                        case "Gerente":
                            lista = logicaNegocio.listarGerentes();
                            break;
                        case "Jefe":
                            lista = logicaNegocio.listarJefes();
                            break;
                        case "Comisionista":
                            lista = logicaNegocio.listarComisionistas();
                            break;
                    }
                    break;
                case "Gerente":
                    switch (cargoListar)
                    {
                        case "Jefe":
                            lista = logicaNegocio.listarMisJefes(idPayee);
                            break;
                        case "Comisionista":
                            lista = logicaNegocio.listarMisComisionistas(idPayee);
                            break;
                    }
                    break;
                case "Jefe":
                    switch (cargoListar)
                    {
                        case "Comisionista":
                            lista = logicaNegocio.listarMisComisionistas(idPayee);
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("No se encontraton resultados", "Lista vacía", MessageBoxButtons.OK);
                    break;

            }
            listaOriginal = new SortableBindingList<Trabajador>(lista);
            dgvUsuarios.DataSource = listaOriginal;
        }

        private void filtrar()
        {
            string filtro = cmbCampo.Text;
            string field = txtDato.Text;

            SortableBindingList<Trabajador> listaAux = new SortableBindingList<Trabajador>();

            Boolean cumple = false;
            foreach (Trabajador trabajador in listaOriginal){
                switch (filtro)
                {
                    case "<Todos>":
                        cumple = trabajador.IdTrabajador.Contains(field)
                                || trabajador.Dni.Contains(field)
                                || trabajador.Email.Contains(field)
                                || trabajador.UserName.Contains(field)
                                || trabajador.Nombre.Contains(field)
                                || trabajador.ApellidoPaterno.Contains(field)
                                || trabajador.ApellidoMaterno.Contains(field)
                                || trabajador.IdTrabajador.Contains(field)
                                || trabajador.Distrito.Contains(field);
                        break;
                    case "ID":
                        cumple = trabajador.IdTrabajador.Contains(field);
                        break;
                    case "Nombre":
                        cumple = trabajador.Nombre.Contains(field);
                        break;
                    case "Apellido Paterno":
                        trabajador.ApellidoPaterno.Contains(field);
                        break;
                    case "Apellido Materno":
                        trabajador.ApellidoMaterno.Contains(field);
                        break;
                    case "Distrito":
                        cumple = trabajador.Distrito.Contains(field);
                        break;
                    default:
                        cumple = true;
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(trabajador);
            }
            dgvUsuarios.DataSource = listaAux;
            dgvUsuarios.Refresh();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDato.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ObjetoSeleccionado = (Trabajador)dgvUsuarios.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtDato_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void FrmVisualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (rbnExcel.Checked == true)
            {
                ExportarExcel excel = new ExportarExcel(dgvUsuarios);
                excel.GenerarExcel();
                MessageBox.Show("Se ha generado correctamente el archivo excel");
            }
            else if (rbnPdf.Checked == true)
            {
                ExportarPdf pdf = new ExportarPdf(dgvUsuarios);
                pdf.ExportarDataGridViewPdf();
                MessageBox.Show("Se ha generado correctamente el archivo pdf");
            }
        }

        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsuarios.Sort(dgvUsuarios.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
