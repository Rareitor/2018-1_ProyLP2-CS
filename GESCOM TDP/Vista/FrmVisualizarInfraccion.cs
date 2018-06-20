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
    public partial class FrmVisualizarInfraccion : Form
    {
        private InfraccionBL logicaInfraccion = new InfraccionBL();
        BindingList<Infraccion> listaInfraccion = new BindingList<Infraccion>();

        public FrmVisualizarInfraccion()
        {
            InitializeComponent();
            listaInfraccion = logicaInfraccion.listarInfracciones();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisualizarInfracciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpFechaInicio.Value;
            DateTime fin = dtpFechaFin.Value;
            BindingList<Infraccion> listaBusqueda = new BindingList<Infraccion>();
            foreach (Infraccion i in listaInfraccion)
            {
                int resultado1 = DateTime.Compare(i.Fecha, inicio);
                int resultado2 = DateTime.Compare(i.Fecha,fin);

                if (resultado1 >= 0 && resultado2 <=0)
                {
                    listaBusqueda.Add(i);
                } 

               
            }

            dgvInfracciones.DataSource = listaBusqueda;

        }
    }
}
