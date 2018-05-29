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
    public partial class FrmFijarPeriodoCalculo : Form
    {
        public FrmFijarPeriodoCalculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el periodo");
            }
            else
            {
                Program.periodoCalculoComisiones = Convert.ToInt32(txtPeriodo.Text);
                MessageBox.Show("Periodo Actualizado");
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FijarPeriodoCalculo_Load(object sender, EventArgs e)
        {

        }
    }
}
