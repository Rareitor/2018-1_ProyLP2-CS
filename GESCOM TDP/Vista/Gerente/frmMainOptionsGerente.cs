using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Otros;

namespace Vista
{
    public partial class frmMainOptionsGerente : Form
    {
        public frmMainOptionsGerente()
        {
            InitializeComponent();
        }

        private void frmMainOptions2_Load(object sender, EventArgs e)
        {

        }

        private void buttonMainOptions2_Click(object sender, EventArgs e)
        {
            GestionarOrdenes gestionarOrdenes = new GestionarOrdenes();
            gestionarOrdenes.Owner = this;
            gestionarOrdenes.ShowDialog();
        }

        private void buttonMainOptions1_Click(object sender, EventArgs e)
        {
            AdministrarCuenta administrarCuenta = new AdministrarCuenta();
            administrarCuenta.Owner = this;
            administrarCuenta.ShowDialog();
        }

        private void buttonMainOptions11_Click(object sender, EventArgs e)
        {
            AñadirNoticias añadirNoticias = new AñadirNoticias();
            añadirNoticias.Owner = this;
            añadirNoticias.ShowDialog();
        }

        private void buttonMainOptions5_Click(object sender, EventArgs e)
        {
            VisualizarRecordVendido visualizarComision = new VisualizarRecordVendido();
            visualizarComision.Owner = this;
            visualizarComision.ShowDialog();
        }

        private void buttonMainOptions7_Click(object sender, EventArgs e)
        {
            VisualizarCanalVenta visCanalVenta = new VisualizarCanalVenta();
            visCanalVenta.Owner = this;
            visCanalVenta.ShowDialog();
        }

        private void buttonMainOptions6_Click(object sender, EventArgs e)
        {
            VisualizarProductos visProductos = new VisualizarProductos();
            visProductos.Owner = this;
            visProductos.ShowDialog();
        }

        private void buttonMainOptions12_Click(object sender, EventArgs e)
        {
            VisualizarInfracciones visualizarInfracciones = new VisualizarInfracciones();
            visualizarInfracciones.Owner = this;
            visualizarInfracciones.ShowDialog();

        }

        private void buttonMainOptions10_Click(object sender, EventArgs e)
        {
            VisualizarJefes visJefes = new VisualizarJefes();
            visJefes.Owner = this;
            visJefes.ShowDialog();

        }

        private void buttonMainOptions8_Click(object sender, EventArgs e)
        {
            VisualizarMapa visualizarMapa = new VisualizarMapa();
            visualizarMapa.Owner = this;
            visualizarMapa.ShowDialog();
        }
    }
}
