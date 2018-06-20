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

namespace Vista
{
    public partial class FrmReportarInfraccion : Form
    {
        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }

        private string idUsu;
        private Infraccion i = new Infraccion();
        private InfraccionBL logicaInfraccion = new InfraccionBL();
        public FrmReportarInfraccion(string idUsuario)
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            idUsu = idUsuario;
            txtIdUsuario.Text = idUsu;
        }
        private void estadoComponentes(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    rtxMotivo.Enabled = false;
                    txtIdUsuario.Enabled = false;

                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    rtxMotivo.Enabled = true;
                    txtIdUsuario.Enabled = false;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    rtxMotivo.Enabled = false;
                    txtIdUsuario.Enabled = false;
                    limpiarComponentes();
                    break;
                }
            }
        private void limpiarComponentes()
        {
            rtxMotivo.Text = "";
            

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
      
        }

        private void ReportarInfraccion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            i.Fecha = DateTime.Now;
            i.Texto = rtxMotivo.Text;
            i.IdPayeeReportador = txtIdUsuario.Text;


            logicaInfraccion.registrarInfraccion(i);
            MessageBox.Show("Se ha registrado correctamente la infraccion", "Registro de Infraccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            estadoComponentes(Estado.Deshabilitado);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
        }
    }
}
