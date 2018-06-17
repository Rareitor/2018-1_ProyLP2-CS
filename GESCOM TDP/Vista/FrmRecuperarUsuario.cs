using Controlador;
using Modelo;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmRecuperarUsuario : Form
    {
        TrabajadorBL logicaNegocio;
        private SortableBindingList<Trabajador> lista;
        public FrmRecuperarUsuario()
        {
            InitializeComponent();
            logicaNegocio = new TrabajadorBL();
            CenterToScreen();
            dgvUsuariosRec.AutoGenerateColumns = false;
            BindingList<Trabajador> listaAux = logicaNegocio.listarTrabajadorPapelera();
            lista = new SortableBindingList<Trabajador>(listaAux);
            dgvUsuariosRec.DataSource = lista;
            dgvUsuariosRec.ReadOnly = true;
            dgvUsuariosRec.AllowUserToAddRows = false;
            if (dgvUsuariosRec.Rows.Count == 0)
            {
                btnSeleccionar.Enabled = false;
                btnSeleccionar.BackColor = System.Drawing.Color.White;
                MessageBox.Show("No hay usuarios por restaurar.", "Restaurar Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cmbCampo.Text = "<Todos>";
            foreach (DataGridViewColumn column in dgvUsuariosRec.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void FrmRecuperarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in this.dgvUsuariosRec.SelectedRows)
            {
                Trabajador trab = (Trabajador)fila.DataBoundItem;
                logicaNegocio.recuperarTrabajador(trab);
                dgvUsuariosRec.Rows.RemoveAt(fila.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuariosRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuariosRec_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsuariosRec.Sort(dgvUsuariosRec.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void filtrar()
        {
            string filtro = cmbCampo.Text;
            string field = txtDato.Text.ToLower();

            SortableBindingList<Trabajador> listaAux = new SortableBindingList<Trabajador>();

            Boolean cumple = false;
            foreach (Trabajador trabajador in lista)
            {
                string razonMin = trabajador.Razon.ToLower();
                string nombreMin = trabajador.Nombre.ToLower();
                string apellidoPatMin = trabajador.ApellidoPaterno.ToLower();
                string apellidoMatMin = trabajador.ApellidoMaterno.ToLower();
                string idTrabajadorMin = trabajador.IdTrabajador.ToLower();
                string dniMin = trabajador.Dni;

                switch (filtro)
                {
                    case "<Todos>":
                        cumple = idTrabajadorMin.Contains(field)
                                || trabajador.Dni.Contains(field)
                                || nombreMin.Contains(field)
                                || apellidoPatMin.Contains(field)
                                || apellidoMatMin.Contains(field)
                                || dniMin.Contains(field)
                                || razonMin.Contains(field);
                        break;
                    case "ID":
                        cumple = idTrabajadorMin.Contains(field);
                        break;
                    case "Nombre":
                        cumple = nombreMin.Contains(field);
                        break;
                    case "Apellido Paterno":
                        cumple = apellidoPatMin.Contains(field);
                        break;
                    case "Apellido Materno":
                        cumple = apellidoMatMin.Contains(field);
                        break;
                    case "DNI":
                        cumple = dniMin.Contains(field);
                        break;
                    case "Razón":
                        cumple = razonMin.Contains(field);
                        break;
                    default:
                        cumple = true;
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(trabajador);
            }
            dgvUsuariosRec.DataSource = listaAux;
            dgvUsuariosRec.Refresh();
        }

        private void txtDato_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDato.Text = "";
        }
    }
}
