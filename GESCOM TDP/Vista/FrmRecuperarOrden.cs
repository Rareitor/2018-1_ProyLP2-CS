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
        public FrmRecuperarOrden()
        {
            InitializeComponent();
            logicaNegocio = new OrdenBL();
            dgvOrden.AutoGenerateColumns = false;
            dgvOrden.DataSource = logicaNegocio.listarOrdenPapelera();
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
    }
}
