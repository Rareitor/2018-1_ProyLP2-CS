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
    public partial class frmMainOptionsAdmin : Form
    {
        public frmMainOptionsAdmin()
        {
            InitializeComponent();
        }

        private void frmMainOptions1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonMainOptions1_Click(object sender, EventArgs e)
        {
            GestionarUsuarios gestionarUsuarios = new GestionarUsuarios();
            gestionarUsuarios.Owner = this;
            gestionarUsuarios.ShowDialog();
        }

        private void buttonMainOptions2_Click(object sender, EventArgs e)
        {
            GestionarOrdenes gestionarOrdenes = new GestionarOrdenes();
            gestionarOrdenes.Owner = this;
            gestionarOrdenes.ShowDialog();
        }

        private void buttonMainOptions3_Click(object sender, EventArgs e)
        {
            GestionarProductos gestionarProductos = new GestionarProductos();
            gestionarProductos.Owner = this;
            gestionarProductos.ShowDialog();
        }

        private void buttonMainOptions7_Click(object sender, EventArgs e)
        {
            FijarPeriodoCalculo fijarPeriodoCalculo = new FijarPeriodoCalculo();
            fijarPeriodoCalculo.Owner = this;
            fijarPeriodoCalculo.ShowDialog();
        }

        private void btnEnviarRecomendaciones_Click(object sender, EventArgs e)
        {
            VerRecomendaciones verRecom = new VerRecomendaciones();
            verRecom.Owner = this;
            verRecom.ShowDialog();
        }

        private void buttonMainOptions5_Click(object sender, EventArgs e)
        {
            RealizarBackup rb = new RealizarBackup();
            rb.Owner = this;
            rb.ShowDialog();
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            PapeleraReciclaje pr = new PapeleraReciclaje();
            pr.Owner = this;
            pr.ShowDialog();
        }
    }
}
