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
    public partial class AñadirNoticias : Form
    {
        private void InicializarArchivo()
        {
            FileStream archNoticias = new FileStream("../../../Archivos/archNoticias.dat", FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archNoticias);

            String data = "";
            while (true)
            {
                String linea = lector.ReadLine();
                if (linea == null) break;
                linea += "\n";
                data += linea;
            }
            richTextBox1.Text = data;
            lector.Close();
            archNoticias.Close();   
        }

        public AñadirNoticias()
        {
            InitializeComponent();
            InicializarArchivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream archNoticias = new FileStream("../../../Archivos/archNoticias.dat", FileMode.Open, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(archNoticias);
            string texto = " ";
            texto = richTextBox1.Text;

            escritor.WriteLine(texto);
            escritor.Close();
            archNoticias.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
