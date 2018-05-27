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
    public partial class FrmPapeleraReciclaje : Form
    {
        public FrmPapeleraReciclaje()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data seleccionada restaurada");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarProducto_Click(object sender, EventArgs e)
        {
            FrmVisualizarProducto frmVisualizarProducto = new FrmVisualizarProducto(true);
            frmVisualizarProducto.ShowDialog();
        }
    }
}
