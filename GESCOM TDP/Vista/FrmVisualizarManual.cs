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
        string fullPath;
        string ruta2;
        public FrmVisualizarManual()
        {

            InitializeComponent();
            
            ruta2 = "C:\\Users\\Oscar\\Documents\\GitHub\\2018-1_ProyLP2-CS\\GESCOM TDP\\Manual.pdf";
            axAcroPDF1.src = ruta2;
            toolStrip1.Visible = false;

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

        public void bajarBits()
        {
            //byte[] a = encoding.GetBytes(strHTML);
            //MemoryStream m = new MemoryStream(a);
            //Response.Clear();
            //Response.AddHeader("Content-Length", a.Length.ToString());
            //Response.ContentType = "application/pdf";
            //Response.AddHeader("Expires", "0");
            //Response.AddHeader("Cache-Control", "must-revalidate, post-check=0, pre-check=0");
            //Response.AddHeader("Pragma", "public");
            //Response.AddHeader("Content-Disposition", "attachment; filename=sample.pdf");
            //Response.BinaryWrite(a);
            //Response.Flush();
            //Response.End();
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
                    Console.WriteLine(ruta);
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
