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
    public partial class FrmGestionarProductoAdmin : Form
    {
        public FrmGestionarProductoAdmin()
        {
            InitializeComponent();
        }

        private void GestionarProductoAdmin_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
