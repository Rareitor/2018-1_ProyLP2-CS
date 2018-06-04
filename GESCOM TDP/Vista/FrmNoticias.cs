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
        BindingList<int> listaV = new BindingList<int>();
        string idUsuario = "";
        public FrmNoticias(string idPayee, BindingList<Noticia> listaNoticia, 
            ref BindingList<int> listaVisitada)
        { 
        
            InitializeComponent();
            idUsuario = idPayee;
            this.listaNoticia= listaNoticia;
            lBNoticias.DataSource = listaNoticia;
            listaV = listaVisitada;
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
            int visitada;
            int index = Int32.Parse(lBNoticias.SelectedValue.ToString());
            string titulo = "";
            string texto = obtenerNoticia(index,ref titulo);
            visitada = verificarSiFueVisitada(index);
            if (visitada == 0)
            {
                logicaNoticias.registrarVisita(index, idUsuario);
                listaV.Add(index);
            }
            
            MessageBox.Show(texto, titulo);

        }
        public int verificarSiFueVisitada(int idNoticia)
        {
            foreach(int e in listaV)
            {
                if (e == idNoticia)
                {
                    return 1;
                }
            }
            return 0;
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

        private void FrmNoticias_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
