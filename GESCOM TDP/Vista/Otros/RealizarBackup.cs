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
    public partial class RealizarBackup : Form
    {
        public RealizarBackup()
        {
            InitializeComponent();
         

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //genenerar el archivo back up en la direccion actual

            string ruta = textBox1.Text;
            ruta += ".dat";
            FileStream arch = new FileStream(ruta, FileMode.Create, FileAccess.Write);


        }

      

    }
}
