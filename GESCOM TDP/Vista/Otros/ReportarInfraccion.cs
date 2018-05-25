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

namespace Vista
{
    public partial class ReportarInfraccion : Form
    {
        public ReportarInfraccion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("../../../Archivos/archRecomendaciones.txt", FileMode.Open, FileAccess.Write);

            StreamWriter escritor = new StreamWriter(archivo);
            escritor.WriteLine(textBox1.Text);
            escritor.WriteLine(richTextBox1.Text);
            escritor.WriteLine(DateTime.Now.Date);
            escritor.Close();
            archivo.Close();
            this.Close();
        }

        private void ReportarInfraccion_Load(object sender, EventArgs e)
        {

        }
    }
}
