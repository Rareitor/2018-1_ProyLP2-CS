using Controlador;
using Modelo;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmRecuperarUsuario : Form
    {
        TrabajadorBL logicaNegocio;
        public FrmRecuperarUsuario()
        {
            InitializeComponent();
            logicaNegocio = new TrabajadorBL();
            dgvUsuariosRec.AutoGenerateColumns = false;
            dgvUsuariosRec.DataSource = logicaNegocio.listarTrabajadorPapelera();
            dgvUsuariosRec.ReadOnly = true;
            dgvUsuariosRec.AllowUserToAddRows = false;
            if (dgvUsuariosRec.Rows.Count == 0)
            {
                btnSeleccionar.Enabled = false;
                MessageBox.Show("No hay usuarios por restaurar");
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
    }
}
