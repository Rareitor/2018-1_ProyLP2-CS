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
            dgvUsuarios.AutoGenerateColumns = false;
            
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

        private void filtrar()
        {
            string filtro = cmbCampo.Text;
            string field = txtDato.Text;

            BindingList<Trabajador> listaAux = new BindingList<Trabajador>();

            Boolean cumple = false;
            foreach (Trabajador trabajador in listaOriginal){
                switch (filtro)
                {
                    case "ID":
                        cumple = trabajador.IdTrabajador.StartsWith(field);
                        break;
                    case "Nombre":
                        cumple = trabajador.Nombre.StartsWith(field)
                                || trabajador.ApellidoPaterno.StartsWith(field)
                                || trabajador.ApellidoMaterno.StartsWith(field);
                        break;
                    case "Distrito":
                        cumple = trabajador.Distrito.StartsWith(field);
                        break;
                    case "Cargo":
                        cumple = trabajador.Cargo.StartsWith(field);
                        break;
                }
                if (!cumple) continue;
                listaAux.Add(trabajador);
            }
            dgvUsuarios.DataSource = listaAux;
            dgvUsuarios.Refresh();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDato.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ocultarSeleccionar()
        {
            btnSeleccionar.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void txtDato_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }
    }
}
