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
    public partial class FrmGestionarOrdenAdmin : Form
    {
        private OrdenBL logicaOrden = new OrdenBL();
        private BindingList<Orden> listaOrden = new BindingList<Orden>();
        private BindingList<Orden> listaEnviar = new BindingList<Orden>();

        public BindingList<Orden> ListaEnviar { get => listaEnviar; set => listaEnviar = value; }

        public FrmGestionarOrdenAdmin()
        {
            InitializeComponent();
            listaOrden = logicaOrden.listarOrden();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idOrden = txtIdOrden.Text;
            string signoFecha = cmbFecha.Text;
            string signoMonto = cmbMonto.Text;
            string idComisionista = txtIdComisionista.Text;
            


            if (chkIdOrden.Checked == true)
            {
                foreach (Orden o in listaOrden)
                {
                    if (o.Id == idOrden)
                    {
                        ListaEnviar.Add(o);
                    }
                }
            }
            else if (chkComisionista.Checked == true && chkFecha.Checked == false && chkMonto.Checked == false)
            {
                foreach (Orden o in listaOrden)
                {
                    if (o.Trabajador.IdTrabajador == idComisionista)
                    {
                        ListaEnviar.Add(o);
                    }
                }
            }
            else if (chkComisionista.Checked == false && chkFecha.Checked == true && chkMonto.Checked == false)
            {
                DateTime fecha = dtpFecha.Value;
                foreach (Orden o in listaOrden)
                {
                    int rpta = DateTime.Compare(fecha, o.FechaVenta);
                    switch (signoFecha)
                    {
                        case "<":
                            if (rpta > 0)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "=":
                            if (rpta == 0)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case ">":
                            if (rpta < 0)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                    }

                }

            } else if (chkComisionista.Checked == false && chkFecha.Checked == false && chkMonto.Checked == true)
            {
                float monto = float.Parse(lblMontoRetribucion.Text);

                foreach (Orden o in listaOrden)
                {
                    switch (signoMonto)
                    {
                        case ">":
                            if (o.Monto > monto)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "<":
                            if (o.Monto < monto)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "=":
                            if (o.Monto == monto)
                            {
                                listaEnviar.Add(o);
                            }
                            break;

                    }
                }
            } else if (chkComisionista.Checked == true && chkFecha.Checked == true && chkMonto.Checked == false)
            {
                DateTime fecha = dtpFecha.Value;
                foreach (Orden o in listaOrden)
                {
                    int rpta = DateTime.Compare(fecha, o.FechaVenta);
                    switch (signoFecha)
                    {
                        case "<":
                            if (rpta > 0 && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "=":
                            if (rpta == 0 && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case ">":
                            if (rpta < 0 && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                    }

                }
            } else if ((chkComisionista.Checked == true && chkFecha.Checked == true && chkMonto.Checked == true))
            {
                float monto = float.Parse(lblMontoRetribucion.Text);

                foreach (Orden o in listaOrden)
                {

                    switch (signoMonto)
                    {
                        case ">":
                            if (o.Monto > monto && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "<":
                            if (o.Monto < monto && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;
                        case "=":
                            if (o.Monto == monto && o.Trabajador.IdTrabajador == idComisionista)
                            {
                                listaEnviar.Add(o);
                            }
                            break;

                    }
                }
            }
            

        
            

            this.DialogResult = DialogResult.OK;
        }

        private void GestionarOrdenAdmin_Load(object sender, EventArgs e)
        {

        }

        public void CambiarTextoBoton(String s)
        {
            btnAnadir.Text = s;
        }

        public void CambiarTextoVentana(String s)
        {
            this.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizarCanal_Click(object sender, EventArgs e)
        {
            FrmVisualizarCanalVenta frmCanalVenta = new FrmVisualizarCanalVenta();
            frmCanalVenta.Show();
        }

        private void btnBuscarComisionista_Click(object sender, EventArgs e)
        {
            frmBuscarSuperior busqSup = new frmBuscarSuperior("COMISIONISTA");
            if (busqSup.ShowDialog() == DialogResult.OK)
            {
                

                txtIdComisionista.Text = busqSup.ObjetoSeleccionado.IdTrabajador;
            }
        }

        private void chkIdOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdOrden.Checked == true)
            {
                txtIdOrden.Enabled = true;
                chkFecha.Enabled = false;
                chkComisionista.Enabled = false;
                chkMonto.Enabled = false;
           } else
            {
                txtIdOrden.Enabled = false;
                chkFecha.Enabled = true;
                chkComisionista.Enabled = true;
                chkMonto.Enabled = true;
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked == true)
            {
                dtpFecha.Enabled = true;
                cmbFecha.Enabled = true;
                chkIdOrden.Enabled = false;
            }

            else
            {
                dtpFecha.Enabled = false;
                cmbFecha.Enabled = false;

                if (chkFecha.Checked==false && chkMonto.Checked== false && chkComisionista.Checked == false)
                {
                    chkIdOrden.Enabled = true;

                }
           
               
            }
        }

        private void chkComisionista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComisionista.Checked == true)
            {
                btnBuscarComisionista.Enabled = true;
                chkIdOrden.Enabled = false;
            }

            else
            {
                btnBuscarComisionista.Enabled = false;

                if (chkFecha.Checked == false && chkMonto.Checked == false && chkComisionista.Checked == false)
                {
                    chkIdOrden.Enabled = true;

                }


            }
        }

        private void chkMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonto.Checked == true)
            {
                lblMontoRetribucion.Enabled = true;
                cmbMonto.Enabled = true;
                chkIdOrden.Enabled = false;
            }

            else
            {
                lblMontoRetribucion.Enabled = false;
                cmbMonto.Enabled = false;

                if (chkFecha.Checked == false && chkMonto.Checked == false && chkComisionista.Checked == false)
                {
                    chkIdOrden.Enabled = true;

                }


            }
        }

        private void lblMontoRetribucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar numeros");
            }
        }

        private void btnBuscarComisionista_Click_1(object sender, EventArgs e)
        {
            frmBuscarSuperior busqSup = new frmBuscarSuperior("COMISIONISTA");
            if (busqSup.ShowDialog() == DialogResult.OK)
            {
                txtIdComisionista.Text = busqSup.ObjetoSeleccionado.IdTrabajador;
            }
        }
    }
}
