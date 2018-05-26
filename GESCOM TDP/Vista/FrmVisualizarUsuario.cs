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
    public partial class FrmVisualizarUsuario : Form
    {
        private BindingList<Trabajador> listaOriginal;
        private TrabajadorBL logicaNegocio;
        String puesto;

        public FrmVisualizarUsuario(String cargoListar, String idPayee, String puesto)
        {
            InitializeComponent();
            this.puesto = puesto;
            logicaNegocio = new TrabajadorBL();
            listaOriginal = new BindingList<Trabajador>();
            switch (this.puesto)
            {
                case "Administrador":
                    switch (cargoListar)
                    {
                        case "Gerente":
                            listaOriginal = logicaNegocio.listarGerentes();
                            break;
                        case "Jefe":
                            listaOriginal = logicaNegocio.listarJefes();
                            break;
                        case "Comisionista":
                            listaOriginal = logicaNegocio.listarComisionistas();
                            break;
                    }
                    break;
                case "Gerente":
                    switch (cargoListar)
                    {
                        case "Jefe":
                            listaOriginal = logicaNegocio.listarMisJefes(idPayee);
                            break;
                        case "Comisionista":
                            listaOriginal = logicaNegocio.listarComisionistas();
                            break;
                    }
                    break;
                case "Jefe":
                    switch (cargoListar)
                    {
                        case "Comisionista":
                            listaOriginal = logicaNegocio.listarMisComisionistas(idPayee);
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("No se encontraton resultados", "Lista vacía", MessageBoxButtons.OK);
                    break;

            }
            dgvUsuarios.DataSource = listaOriginal;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();
            if (!opcion.Equals(""))
            {
                if (txtDato.Text.Equals(""))
                {
                    MessageBox.Show("Escriba un dato para buscar");
                }
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDato.Text = "";
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisualizarComisionista_Load(object sender, EventArgs e)
        {

        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }
    }
}
