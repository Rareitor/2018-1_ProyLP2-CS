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
    public partial class FrmMainOptionsAdmin : Form
    {
        //private FrmLogin logPadre;
        //public FrmMainOptionsAdmin(string usuario, FrmLogin log)
        //{
        //    InitializeComponent();
        //    logPadre = log;

        //    switch (usuario)
        //    {
        //        case ("Administrador"):
        //            toolVisualizacion.Visible = false;
        //            tsmiCalculoComisiones.Visible = false;
        //            tsmiReportarInfraccion.Visible = false;
        //            tsmiVerMapa.Visible = false;
        //            //tsmiActualizarMapa.Visible = false;
        //            tsmiVisualizarGerentes.Visible = false;
        //            break;
        //        case ("Gerente"):
        //            tsmiGestionarUsuario.Visible = false;
        //            tsmiGestionarProductos.Visible = false;
        //            tsmiFijarPeriodo.Visible = false;
        //            tsmiVisualizarGerentes.Visible = false;
        //            tsmiPapelera.Visible = false;
        //            tsmiBackup.Visible = false;
        //            tsmiEnviarRecomendaciones.Visible = false;
        //            tsmiReportarInfraccion.Visible = false;
        //            break;
        //        case ("Jefe"):
        //            tsmiGestionarUsuario.Visible = false;
        //            tsmiGestionarProductos.Visible = false;
        //            tsmiCalculo.Visible = false;
        //            tsmiVisualizarJefes.Visible = false;
        //            tsmiInfracciones.Visible = false;
        //            tsmiEnviarRecomendaciones.Visible = false;
        //            tsmiPapelera.Visible = false;
        //            tsmiBackup.Visible = false;
        //            //tsmiAñadirNoticia.Visible = false;
        //            tsmiVerMapa.Visible = false;
        //            tsmiVisualizarGerentes.Visible = false;
        //            break;
        //        case ("Comisionista"):
        //            tsmiGestionarUsuario.Visible = false;
        //            tsmiGestionarProductos.Visible = false;
        //            tsmiCalculo.Visible = false;
        //            tsmiPersonalACargo.Visible = false;
        //            tsmiInfracciones.Visible = false;
        //            tsmiEnviarRecomendaciones.Visible = false;
        //            tsmiPapelera.Visible = false;
        //            tsmiBackup.Visible = false;
        //            //tsmiAñadirNoticia.Visible = false;
        //            //tsmiActualizarMapa.Visible = false;
        //            tsmiVisualizarGerentes.Visible = false;
        //            break;
        //    }
        //}

        //private void papeleraDeReciclajeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmPapeleraReciclaje papelera = new FrmPapeleraReciclaje();
        //    papelera.MdiParent = this;
        //    papelera.Show();
        //}

        //private void enviarRecomendacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarRecomendacion verRecom = new FrmVisualizarRecomendacion
        //    {
        //        MdiParent = this
        //    };
        //    verRecom.Show();
        //}

        //private void frmMainOptionsAdmin_Load(object sender, EventArgs e)
        //{
        //    //this.WindowState = FormWindowState.Maximized;
        //}

        //private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //this.DialogResult = DialogResult.OK;
        //    logPadre.limpiarTxts();
        //    this.Dispose();
            
        //}

        //private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmRealizarBackup backup = new FrmRealizarBackup();
        //    backup.MdiParent = this;
        //    backup.Show();
        //}

        //private void actualizarMapaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarMapa mapa = new FrmVisualizarMapa();
        //    mapa.MdiParent = this;
        //    mapa.Show();
        //}

  
        //private void gestionarUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    FrmGestionarUsuario gestionarUsuarios = new FrmGestionarUsuario();
        //    gestionarUsuarios.MdiParent = this;
        //    gestionarUsuarios.Show();
        //}



        //private void gestionarProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    FrmGestionarProducto gestionarProductos = new FrmGestionarProducto();
        //    gestionarProductos.MdiParent = this;
        //    gestionarProductos.Show();
        //}

        //private void fijarPeriodoDeCálculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    FrmFijarPeriodoCalculo fijarPeriodoCalculo = new FrmFijarPeriodoCalculo();
        //    fijarPeriodoCalculo.MdiParent = this;
        //    fijarPeriodoCalculo.Show();
        //}

        //private void calcularComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Comision calculada");
        //}

        //private void misComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarRecordVendido visualizarComision = new FrmVisualizarRecordVendido();
        //    visualizarComision.MdiParent = this;
        //    visualizarComision.Show();
        //}

        //private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarProducto visProductos = new FrmVisualizarProducto();
        //    visProductos.MdiParent = this;
        //    visProductos.Show();
        //}

        //private void añadirNoticiasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmAñadirNoticia añadirNoticias = new FrmAñadirNoticia();
        //    añadirNoticias.MdiParent = this;
        //    añadirNoticias.Show();
        //}

        //private void canalesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarCanalVenta frmVisCanalVenta = new FrmVisualizarCanalVenta();
        //    frmVisCanalVenta.ocultarSeleccionar();
        //    frmVisCanalVenta.MdiParent = this;
        //    frmVisCanalVenta.Show();
        //}

        //private void infraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarInfraccion visualizarInfracciones = new FrmVisualizarInfraccion();
        //    visualizarInfracciones.MdiParent = this;
        //    visualizarInfracciones.Show();
        //}

        //private void jefesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarJefe frmVisJefes = new FrmVisualizarJefe();
        //    frmVisJefes.ocultarSeleccionar();
        //    frmVisJefes.MdiParent = this;
        //    frmVisJefes.Show();
        //}

        //private void comisionistaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarComisionista frmVisComisionista = new FrmVisualizarComisionista();
        //    frmVisComisionista.ocultarSeleccionar();
        //    frmVisComisionista.MdiParent = this;
        //    frmVisComisionista.Show();
        //}

        //private void noticiasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmNoticias noticias = new FrmNoticias();
        //    noticias.MdiParent = this;
        //    noticias.Show();
        //}

        //private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmAdministrarCuenta administrarCuenta = new FrmAdministrarCuenta();
        //    administrarCuenta.MdiParent = this;
        //    administrarCuenta.Show();
        //}

        //private void reportarInfracciónToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmReportarInfraccion reportarInfraccion = new FrmReportarInfraccion();
        //    reportarInfraccion.MdiParent = this;
        //    reportarInfraccion.Show();
        //}

        //private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmCambiarContraseña cambiarContrasena = new FrmCambiarContraseña();
        //    cambiarContrasena.Show();
        //}

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void toolAdministracion_Click(object sender, EventArgs e)
        //{

        //}

        //private void gerentesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmVisualizarGerente frmVisGerente = new FrmVisualizarGerente();
        //    frmVisGerente.ocultarSeleccionar();
        //    frmVisGerente.MdiParent = this;
        //    frmVisGerente.Show();
        //}
    }
}
