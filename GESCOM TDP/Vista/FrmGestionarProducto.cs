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
    public partial class FrmGestionarComboProducto : Form
    {
        public FrmGestionarComboProducto()
        {
            InitializeComponent();
            if (Owner is FrmVentanaAdministracion)
            {
                //source -> Adminstrador
            };
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmGestionarProductoAdmin gest = new FrmGestionarProductoAdmin();
            gest.CambiarTextoBoton("Añadir");
            gest.CambiarTextoVentana("Añadir nuevo producto");
            gest.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmGestionarProductoAdmin gest = new FrmGestionarProductoAdmin();
            gest.CambiarTextoBoton("Modificar");
            gest.CambiarTextoVentana("Modificar producto");
            gest.Show();
        }

        private void GestionarProductos_Load(object sender, EventArgs e)
        {

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnExportar_Click(object sender, EventArgs e)
        {
            FrmElegirTipoExportar frm = new FrmElegirTipoExportar();
            frm.Show();
        }

        private void tsbtnBusquedaPer_Click(object sender, EventArgs e)
        {
            FrmBusquedaProductoPersonalizado frmBusPer = new FrmBusquedaProductoPersonalizado();
            frmBusPer.Show();
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            FrmConfirmaBorrar frmConfBorr = new FrmConfirmaBorrar();
            frmConfBorr.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime periodo =dtPeriodo.Value;
            int mes = periodo.Month;
            int year = periodo.Year;

           // DateTime primer = DateTime(periodo.Year, periodo.Month, 1);
        }
    }
}
