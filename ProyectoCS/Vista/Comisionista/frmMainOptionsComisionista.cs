using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Otros;

namespace Vista
{
    public partial class frmMainOptionsComisionista : Form
    {
        public frmMainOptionsComisionista()
        {
            InitializeComponent();
        }

        private void buttonMainOptions2_Click(object sender, EventArgs e)
        {
            GestionarOrdenes gestionarOrdenes = new GestionarOrdenes();
            gestionarOrdenes.Owner = this;
            gestionarOrdenes.ShowDialog();
        }

        private void buttonMainOptions3_Click(object sender, EventArgs e)
        {
            ReportarInfraccion reportarInfraccion = new ReportarInfraccion();
            reportarInfraccion.Owner = this;
            reportarInfraccion.ShowDialog();
        }

        private void buttonMainOptions1_Click(object sender, EventArgs e)
        {
            AdministrarCuenta administrarCuenta = new AdministrarCuenta();
            administrarCuenta.Owner = this;
            administrarCuenta.ShowDialog();
        }

        private void buttonMainOptions4_Click(object sender, EventArgs e)
        {
            Noticias noticias = new Noticias();
            noticias.Owner = this;
            noticias.ShowDialog();
        }

        private void buttonMainOptions10_Click(object sender, EventArgs e)
        {
            VerRecomendaciones verRecomendaciones = new VerRecomendaciones();
            verRecomendaciones.Owner = this;
            verRecomendaciones.ShowDialog();
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
    }
}
