using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Otros
{
    public partial class VisualizarInfracciones : Form
    {
        private void InicializarArchivo()
        {
            FileStream archInfracciones = new FileStream("../../../Archivos/archInfracciones.dat", FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archInfracciones);

          //generar una lisa

            lector.Close();
            archInfracciones.Close();
        }

        public VisualizarInfracciones()
        {
            InitializeComponent();
            InicializarArchivo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}
