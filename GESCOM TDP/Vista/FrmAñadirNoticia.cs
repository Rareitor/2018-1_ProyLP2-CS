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
    public partial class FrmAñadirNoticia : Form
    {
        Noticia n = new Noticia();
        NoticiaBL logicaNoticia = new NoticiaBL();

        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }

        public FrmAñadirNoticia(string id_usuario)
        {
            InitializeComponent();
            n.Trabajador = new Trabajador();
            n.Trabajador.IdTrabajador = id_usuario;
            estadoComponentes(Estado.Inicial);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirNoticias_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rtxNoticia_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
        }

        private void estadoComponentes(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    rtxNoticia.Enabled = false;
                    rtxTitulo.Enabled = false;
                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    rtxNoticia.Enabled = true;
                    rtxTitulo.Enabled = true;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    rtxNoticia.Enabled = false;
                    rtxTitulo.Enabled = false;
                    limpiarComponentes();
                    break;

            }
        }

        private void limpiarComponentes()
        {
            rtxTitulo.Text = "";
            rtxNoticia.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            n.Fecha = DateTime.Now;
            n.Texto = rtxNoticia.Text;
            n.Titulo = rtxTitulo.Text;
            logicaNoticia.registrarNoticia(n);
            MessageBox.Show("Se ha registrado correctamente la noticia");
            estadoComponentes(Estado.Deshabilitado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
