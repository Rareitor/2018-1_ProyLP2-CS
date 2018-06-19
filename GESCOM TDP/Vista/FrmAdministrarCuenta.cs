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
    public partial class FrmAdministrarCuenta : Form
    {
        public FrmAdministrarCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("") || (txtCorreo.Text.Equals("")) || (txtDireccion.Text.Equals("")))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                MessageBox.Show("Datos Actualizados");
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void AdministrarCuenta_Load(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("") || (txtCorreo.Text.Equals("")) || (txtDireccion.Text.Equals("")))
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                MessageBox.Show("Datos Actualizados");
                
            }
        }

       
    }
}
