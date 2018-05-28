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

        public FrmVisualizarUsuario()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            cmbCampo.Text = "<Todos>";
        }

        public FrmVisualizarUsuario(String cargoListar, String idPayee, String puesto)
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            cmbCampo.Text = "<Todos>";

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
                    case "<Todos>":
                        cumple = trabajador.IdTrabajador.Contains(field)
                                || trabajador.Dni.Contains(field)
                                || trabajador.Email.Contains(field)
                                || trabajador.UserName.Contains(field)
                                || trabajador.Nombre.Contains(field)
                                || trabajador.ApellidoPaterno.Contains(field)
                                || trabajador.ApellidoMaterno.Contains(field)
                                || trabajador.IdTrabajador.Contains(field)
                                || trabajador.Distrito.Contains(field);
                        break;
                    case "ID":
                        cumple = trabajador.IdTrabajador.Contains(field);
                        break;
                    case "Nombre":
                        cumple = trabajador.Nombre.Contains(field);
                        break;
                    case "Apellido Paterno":
                        trabajador.ApellidoPaterno.Contains(field);
                        break;
                    case "Apellido Materno":
                        trabajador.ApellidoMaterno.Contains(field);
                        break;
                    case "Distrito":
                        cumple = trabajador.Distrito.Contains(field);
                        break;
                    default:
                        cumple = true;
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

        private void FrmVisualizarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
