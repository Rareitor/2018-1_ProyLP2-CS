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
    public partial class FrmVisualizarJefe : Form
    {
        public FrmVisualizarJefe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVisualizarJefes_Load(object sender, EventArgs e)
        {

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();
            if (opcion == null || opcion.Equals(""))
            {
                if (txtDato.Text.Equals(""))
                {
                    MessageBox.Show("Escriba un dato para buscar");
                }
            }
            else
            {
                MessageBox.Show("Buscando");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }
    }
}
