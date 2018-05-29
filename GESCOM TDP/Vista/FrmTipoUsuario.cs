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
    public partial class FrmTipoUsuario : Form
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoUsuario.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese una opción");
            }
            else
            {
                string tipoUsu = cmbTipoUsuario.Text;
                FrmGestionarUsuarioAdmin gest = new FrmGestionarUsuarioAdmin(tipoUsu);
                gest.CambiarTextoBoton("Añadir");
                gest.CambiarTextoVentana("Nuevo Usuario");
                gest.Show();
            }
        }

        private void frmTipoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
