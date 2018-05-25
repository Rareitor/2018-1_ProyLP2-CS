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
    public partial class FrmCambiarContraseña : Form
    {
        public FrmCambiarContraseña()
        {
            InitializeComponent();
            txtContrasenaActual.PasswordChar = '*';
            txtContrasenaNueva.PasswordChar = '*';
            txtConfirmarContrasena.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtContrasenaNueva.Text == txtConfirmarContrasena.Text && !txtContrasenaNueva.Text.Equals(""))
            {
                MessageBox.Show("Contraseña actualizada");
                this.Close();
            }
            else if (txtContrasenaNueva.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la contraseña");
            }
            else
            {
                MessageBox.Show("Por favor, verique que las contraseñas coincidan.", "Las contraseñas no coinciden");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(chkVer.Checked)
                txtContrasenaActual.PasswordChar = '\0';
            else
                txtContrasenaActual.PasswordChar = '*';
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) button1_Click(sender, e);
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
