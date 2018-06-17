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
        private FrmVentanaAdministracion padre;
        public FrmPapeleraReciclaje(FrmVentanaAdministracion padre)
        {
            InitializeComponent();
            this.padre = padre;
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
            frmVisualizarProducto.Text = "Recuperar Producto";
            this.padre.AbrirFormInPanel(frmVisualizarProducto);
        }

        private void btnRecuperarUsuario_Click(object sender, EventArgs e)
        {
            FrmRecuperarUsuario frmRecuperarUsuario = new FrmRecuperarUsuario();
            frmRecuperarUsuario.Text = "Recuperar Usuarios";
            this.padre.AbrirFormInPanel(frmRecuperarUsuario);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            FrmRecuperarUsuario frmRecuperarUsuario = new FrmRecuperarUsuario();
            frmRecuperarUsuario.Text = "Recuperar Usuarios";
            this.padre.AbrirFormInPanel(frmRecuperarUsuario);
        }

        private void picUsuario_Click(object sender, EventArgs e)
        {
            FrmRecuperarUsuario frmRecuperarUsuario = new FrmRecuperarUsuario();
            frmRecuperarUsuario.Text = "Recuperar Usuarios";
            this.padre.AbrirFormInPanel(frmRecuperarUsuario);
        }

        private void picProducto_Click(object sender, EventArgs e)
        {
            FrmVisualizarProducto frmVisualizarProducto = new FrmVisualizarProducto(true);
            frmVisualizarProducto.Text = "Recuperar Producto";
            this.padre.AbrirFormInPanel(frmVisualizarProducto);
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            FrmVisualizarProducto frmVisualizarProducto = new FrmVisualizarProducto(true);
            frmVisualizarProducto.Text = "Recuperar Producto";
            this.padre.AbrirFormInPanel(frmVisualizarProducto);
        }

        private void picOrden_Click(object sender, EventArgs e)
        {
            FrmRecuperarOrden frmRecuperarOrden = new FrmRecuperarOrden();
            frmRecuperarOrden.Text = "Recuperar Orden";
            this.padre.AbrirFormInPanel(frmRecuperarOrden);
        }

        private void lblOrden_Click(object sender, EventArgs e)
        {
            FrmRecuperarOrden frmRecuperarOrden = new FrmRecuperarOrden();
            frmRecuperarOrden.Text = "Recuperar Orden";
            this.padre.AbrirFormInPanel(frmRecuperarOrden);
        }
    }
}
