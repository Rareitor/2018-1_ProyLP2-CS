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
    public partial class FrmVisualizarOrden : Form
    {
        private OrdenBL logicaNegocio;
        BindingList<Orden> listaOrdenes;
        private string puesto;
        private string idPayee;

        public FrmVisualizarOrden(string puesto, string idPayee)
        {
            InitializeComponent();
            this.puesto = puesto;
            logicaNegocio = new OrdenBL();
            listaOrdenes = new BindingList<Orden>();
            dgvRecord.AutoGenerateColumns = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            BindingList<Orden> listaAux = new BindingList<Orden>();
            string filtro = cbCampo.Text;
            string field = tbFiltro.Text;
            

            Boolean cumple = false;
            Double monto = 0.0;
            foreach (Orden orden in listaOrdenes)
            {
                switch (filtro)
                {
                    case "<Todos>":
                        cumple = orden.Id.Contains(field)
                                || orden.NombreTrabajadorCompleto.Contains(field)
                                || orden.NombreProducto.Contains(field)
                                || orden.NombreCanal.Contains(field)
                                || orden.Distrito.Contains(field);
                        break;
                    case "Comisionsita":
                        cumple = orden.NombreTrabajadorCompleto.Contains(field);
                        break;
                    case "Producto":
                        cumple = orden.NombreProducto.Contains(field);
                        break;
                    case "Canal":
                        cumple = orden.NombreCanal.Contains(field);
                        break;
                    case "Distrito":
                        cumple = orden.Distrito.Contains(field);
                        break;
                    default:
                        cumple = true;
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(orden);
                monto += orden.Monto;
            }
            dgvRecord.DataSource = listaAux;
            dgvRecord.Refresh();
            textBoxTotal.Text = monto.ToString("0.00");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            DateTime fecha1 = dtpFechaInicio.Value;
            DateTime fecha2 = dtpFechaFin.Value;
            Double subtotal;
            switch (puesto)
            {
                case "Comisionista":
                    listaOrdenes = logicaNegocio.listarOrdenesComisionista(this.idPayee, fecha1, fecha2);
                    break;
                case "Jefe":
                    listaOrdenes = logicaNegocio.listarOrdenesJefe(this.idPayee, fecha1, fecha2);
                    break;
                default:
                    listaOrdenes = logicaNegocio.listarOrdenesGerente(fecha1, fecha2);
                    break;
            }
            subtotal = listaOrdenes.Sum(Orden => Orden.Monto);
            textBoxTotal.Text = subtotal.ToString();
            dgvRecord.DataSource = listaOrdenes;
            dgvRecord.Refresh();
            cbCampo.Enabled = true;

            tbFiltro.Enabled = true;
            buttonBuscar.Enabled = true;
            cbCampo.Text = "<Todos>";
        }
       
    }
}
