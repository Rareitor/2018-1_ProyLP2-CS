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
    public partial class FrmVisualizarRecomendacion : Form
    {
        private void InicializarArchivo()
        {
            FileStream archNoticias = new FileStream("../../../Archivos/archRecomendaciones.dat", FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archNoticias);

            String data = "";
            while (true)
            {
                String linea = lector.ReadLine();
                if (linea == null) break;
                linea += "\n";
                data += linea;
            }
            rtxRecomendacion.Text = data;
            lector.Close();
            archNoticias.Close();
        }

        public FrmVisualizarRecomendacion()
        {
            InitializeComponent();
            InicializarArchivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerRecomendaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
