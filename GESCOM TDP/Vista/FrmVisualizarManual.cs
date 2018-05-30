using Controlador;
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
    public partial class FrmVisualizarManual : Form
    {
        string ruta="";
        ManualBL logicaManual = new ManualBL();

        public FrmVisualizarManual()
        {
            InitializeComponent();
        }

        private static byte[] GetPhoto(string filePath)
        {

            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

            private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();

            try
            {
                archivo.Filter = "Archivo PDF|*.pdf";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    ruta = archivo.FileName;
                    axAcroPDF1.src = archivo.FileName;

                    byte[] bits = GetPhoto(ruta);

                    //logicaManual.SubirArchivo(bits);
                    MessageBox.Show("Se ha subido correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
    }
}
