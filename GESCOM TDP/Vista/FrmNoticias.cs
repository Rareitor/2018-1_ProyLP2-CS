using Controlador;
using Modelo;
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
    public partial class FrmNoticias : Form
    {
        private NoticiaBL logicaNoticias = new NoticiaBL();
        BindingList<Noticia> listaNoticia;
        public FrmNoticias()
        {
            InitializeComponent();

            listaNoticia= logicaNoticias.listarNoticias();
            lBNoticias.DataSource = listaNoticia;
            lBNoticias.DisplayMember = "mostrar";
            lBNoticias.ValueMember ="id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void lBNoticias_Click(object sender, EventArgs e)
        {
            // Noticia n = lBNoticias.SelectedValue();

            int index = Int32.Parse(lBNoticias.SelectedValue.ToString());
            string titulo = "";
            string texto = obtenerNoticia(index,ref titulo);

            MessageBox.Show(texto, titulo);

        }

        private string obtenerNoticia(int i, ref string titulo)
        {
            foreach(Noticia n in listaNoticia)
            {
                if (n.Id == i)
                {
                    titulo = n.Titulo;
                    return n.Texto;
                }
            }
            return "";
        }
    }
}
