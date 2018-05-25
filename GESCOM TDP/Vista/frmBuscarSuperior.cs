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

namespace Vista
{
    public partial class frmBuscarSuperior : Form
    {
        private string tipoUsuBus = "";
        private  TrabajadorBL logicaTrabajador = new TrabajadorBL();
        private Trabajador objetoSeleccionado;


        BindingList<Trabajador> listaTrabajador = new BindingList<Trabajador>();
        public frmBuscarSuperior(string tipoUsu)
        {
            InitializeComponent();
            
            tipoUsuBus = tipoUsu;

            if (tipoUsuBus == "GERENTE"){
                listaTrabajador = logicaTrabajador.listarGerentes();
            } else if(tipoUsuBus == "JEFE")
            {
                listaTrabajador = logicaTrabajador.listarJefes();
            } else if (tipoUsu == "COMISIONISTA")
            {
                listaTrabajador = logicaTrabajador.listarComisionistas();
            }
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = listaTrabajador;

        }

        public Trabajador ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmBusquedaUsuarioPersonalizada frmBusPer = new FrmBusquedaUsuarioPersonalizada(listaTrabajador);
            if (frmBusPer.ShowDialog() == DialogResult.OK)
            {
                pnlBusqueda.Visible = true;
                BindingList<Trabajador> lista = logicaTrabajador.busquedaPersonalizada(frmBusPer.Dni, frmBusPer.Nombre, frmBusPer.ApellidoPat, frmBusPer.ApellidMat, frmBusPer.Correo);
                dgvBusqueda.AutoGenerateColumns = false;

                dgvBusqueda.DataSource = lista;



            }
        }

        private void pnlBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjetoSeleccionado = (Trabajador)dgvBusqueda.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
