using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Otros
{
    public partial class FrmVisualizarCanalVenta : Form
    {
        private CanalBL logicaNegocio;
        private BindingList<Canal> listaOriginal;
        public FrmVisualizarCanalVenta()
        {
            InitializeComponent();
            logicaNegocio = new CanalBL();
            listaOriginal = logicaNegocio.listarCanal();
            dgvCanalVenta.AutoGenerateColumns = false;
            dgvCanalVenta.DataSource = listaOriginal;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            string filtro = textBox1.Text;
            BindingList<Canal> listaFiltrada = new BindingList<Canal>();
            foreach (Canal canal in listaOriginal)
            {
                if (canal.Nombre.Contains(filtro.ToLower()) ||
                    canal.Nombre.Contains(filtro.ToUpper()))
                {
                    listaFiltrada.Add(canal);
                }
            }
            dgvCanalVenta.DataSource = listaFiltrada;
            dgvCanalVenta.Refresh();
        }
    }
}
