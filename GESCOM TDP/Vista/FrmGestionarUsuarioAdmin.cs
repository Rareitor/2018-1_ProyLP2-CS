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
    public partial class FrmGestionarUsuarioAdmin : Form
    {
        private string tipoUsuario;
        public FrmGestionarUsuarioAdmin()
        {
            InitializeComponent();
        }

        public FrmGestionarUsuarioAdmin(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;

            if (tipoUsuario.Equals("Gerente"))
            {
                txtJefeDirecto.Enabled = false;
                this.btnBuscarJefe.Hide();
            }
        }


        private void GestionarUsuarioAdmin_Load(object sender, EventArgs e)
        {

        }

        public void CambiarTextoBoton(String s)
        {
            btnAnadir.Text = s;
        }

        public void CambiarTextoVentana(String s)
        {
            this.Text = s;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtJefeDirecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarJefe_Click(object sender, EventArgs e)
        {
            switch (tipoUsuario)
            {
                case "Comisionista":
                    FrmVisualizarJefe frmJefe = new FrmVisualizarJefe();
                    frmJefe.Show();
                    break;
                case "Jefe":
                    FrmVisualizarGerente frmGere = new FrmVisualizarGerente();
                    frmGere.Show();
                    break;
            }
        }
    }
}
