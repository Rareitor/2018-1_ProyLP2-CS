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
    public partial class FrmVisualizarGerente : Form
    {
        public FrmVisualizarGerente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void VisualizarGerente_Load(object sender, EventArgs e)
        {

        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
