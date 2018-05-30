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
using Vista.Otros;

namespace Vista
{
    public partial class FrmGestionarUsuario : Form
    {
        Trabajador t;
        BindingList<Sede> listaSede;
        TrabajadorBL logicaTrabajador = new TrabajadorBL();
        Trabajador objetoSeleccionado = new Trabajador();
        private string idSupSup;
        private SortableBindingList<Trabajador> listaOriginal;
        BindingList<String> listaCorreos = new BindingList<string>();
        BindingList<String> listaDni = new BindingList<string>();
        //por defecto 1: crear un usuario, 2:actualizar un usuario
        int opcion=1;
        int validoCorreo = 0;
        int validoDni = 0;
        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }

        public FrmGestionarUsuario()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
            llenarComboBox();
            pnlBusqueda.Visible = false;
            cmbCampo.Text = "<Todos>";
            foreach (DataGridViewColumn column in dgvBusqueda.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }


        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBusqueda.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    labelDni.Visible = false;
                    txtID.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    dateIngreso.Enabled = false;
                    MensajeCorreo.Visible = false;
                    pictureCheked.Visible = false;
                    txtApellidoPat.Enabled = false;
                    txtApellidoPat.Enabled = false;
                    rbnComisionista.Enabled = false;
                    rbnGerente.Enabled = false;
                    rbnJefe.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    txtIDSuperior.Enabled = false;
                    txtCorreo.Enabled = false;
                    btnSuperior.Enabled = false;
                    cmbSede.Enabled = false;
                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBusqueda.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtID.Enabled = false;
                    txtDNI.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidoPat.Enabled = true;
                    txtApellidoMat.Enabled = true;
                    rbnComisionista.Enabled = true;
                    rbnGerente.Enabled = true;
                    dateIngreso.Enabled = true;
                    rbnJefe.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = true;
                    txtIDSuperior.Enabled = false;
                    btnSuperior.Enabled = false;
                    cmbSede.Enabled = true;
                    txtCorreo.Enabled = true;
                    btnCancelar.Enabled = true;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBusqueda.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtID.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    dateIngreso.Enabled = false;
                    txtApellidoPat.Enabled = false;

                    labelDni.Visible = false;
                    txtApellidoMat.Enabled = false;
                    MensajeCorreo.Visible = false;
                    pictureCheked.Visible = false;
                    rbnComisionista.Enabled = false;
                    rbnGerente.Enabled = false;
                    rbnJefe.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtIDSuperior.Enabled = false;
                    btnSuperior.Enabled = false;
                    cmbSede.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtIDSuperior.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            dateIngreso.Value = DateTime.Now;
            txtUsuario.Text = "";
            rbnJefe.Checked = false;
            rbnComisionista.Checked = false;
            rbnGerente.Checked = false;
            cmbSede.SelectedItem = -1;

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario frmTipo = new FrmTipoUsuario();
            frmTipo.Show();
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuarioAdmin tipoUs = new FrmGestionarUsuarioAdmin();
            tipoUs.CambiarTextoBoton("Modificar");
            tipoUs.CambiarTextoVentana("Modificar Usuario");
            tipoUs.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBusquedaPers_Click(object sender, EventArgs e)
        {
            FrmBusquedaUsuarioPersonalizada frmBusPer = new FrmBusquedaUsuarioPersonalizada();
            frmBusPer.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //opcion = 2;

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            labelDni.Visible = false;
            pnlBusqueda.Visible = true;
            BindingList<Trabajador> lista = logicaTrabajador.listarPayees();
            listaOriginal = new SortableBindingList<Trabajador>(lista);
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = listaOriginal;
        }

  
    

        private void tsbtnExportar_Click(object sender, EventArgs e)
        {
            FrmElegirTipoExportar frm = new FrmElegirTipoExportar();
            frm.Show();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            FrmConfirmaBorrar frmConfBorr = new FrmConfirmaBorrar();
            frmConfBorr.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuarioAdmin tipoUs = new FrmGestionarUsuarioAdmin();
            tipoUs.CambiarTextoBoton("Modificar");
            tipoUs.CambiarTextoVentana("Modificar Usuario");
            tipoUs.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario frmTipo = new FrmTipoUsuario();
            frmTipo.Show();
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gbGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = txtDNI.Text;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int validarTodo = 0;
            if (opcion == 1)
            {
                if (validoCorreo == 1 && validoDni ==1)
                {
                    if (rbnComisionista.Checked == false && rbnJefe.Checked == false && rbnGerente.Checked == false)
                    {
                        validarTodo = 0;
                    } else
                    {
                        validarTodo = 1;
                    }
                   
                }
            } else if (opcion == 2)
            {
                if (rbnComisionista.Checked == false && rbnJefe.Checked == false && rbnGerente.Checked == false)
                {
                    validarTodo = 0;
                }
                else
                {
                    validarTodo = 1;
                }
            }

            if (validarTodo == 0)
            {
                MessageBox.Show("Ingrese datos de un usuario valido");
            }
            else
            {
                estadoComponentes(Estado.Deshabilitado);
                pnlBusqueda.Visible = false;
                if (rbnComisionista.Checked == true)
                {
                    Comisionista c = new Comisionista();
                    t = (Trabajador)c;

                }
                else if (rbnGerente.Checked == true)
                {
                    Gerente g = new Gerente();
                    t = (Trabajador)g;

                }
                else if (rbnJefe.Checked == true)
                {
                    Jefe j = new Jefe();
                    t = (Trabajador)j;

                }

                t.Dni = txtDNI.Text;
                t.Nombre = txtNombre.Text;
                t.ApellidoMaterno = txtApellidoMat.Text;
                t.ApellidoPaterno = txtApellidoPat.Text;
                t.UserName = txtUsuario.Text;
                t.Password = txtContraseña.Text;
                t.Superior = idSupSup; //se refiere al superior del seleccionado dgv
                t.FechaIngreso = dateIngreso.Value;
                t.IdTrabajador = txtID.Text;
                
                string idSuperior = txtIDSuperior.Text;

                t.Email = txtCorreo.Text;
                int idSede = asignarIdSede(cmbSede.Text);

                t.Locacion = new Sede();
                t.Locacion.IdLocal = idSede;

                string idUsuario = logicaTrabajador.gestionarUsuarios(t, idSuperior, opcion);

                if (idUsuario != "Correcto")
                {
                    txtID.Text = idUsuario;
                    MessageBox.Show("Se ha registrado correctamente");

                    listaCorreos = logicaTrabajador.listarCorreos();
                    listaDni = logicaTrabajador.listarDni();
                }
                else if (idUsuario == "Correcto")
                {
                    MessageBox.Show("Se ha actualizado correctamente");
                }

                opcion = 1;
            }
        }

        public int asignarIdSede(String sitio)
        {
            foreach(Sede s in listaSede)
            {
                if (s.Distrito == sitio)
                {
                    return s.IdLocal;
                }
            }
            return -1;
        }
        SedeBL logicaSede= new SedeBL();
        public void llenarComboBox()
        {
            cmbSede.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbSede.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            listaSede = logicaSede.listarSedes();

            for (int i = 0; i < listaSede.Count; i++)
            {

                datos.Add(listaSede[i].ToString());
                Console.WriteLine(listaSede[i]);
            }

            cmbSede.AutoCompleteCustomSource = datos;
            cmbSede.DataSource = listaSede;
            cmbSede.SelectedItem = -1;


        }
        private void btnSuperior_Click(object sender, EventArgs e)
        {

        }

        private void rbnGerente_CheckedChanged(object sender, EventArgs e)
        {
            btnSuperior.Enabled = true;

        }

        private void rbnJefe_CheckedChanged(object sender, EventArgs e)
        {
            btnSuperior.Enabled = true;
        }

        private void rbnComisionista_CheckedChanged(object sender, EventArgs e)
        {

            btnSuperior.Enabled = true;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            rbnGerente.Enabled = false;
            rbnComisionista.Enabled = false;
            rbnJefe.Enabled = false;

            objetoSeleccionado = (Trabajador)dgvBusqueda.CurrentRow.DataBoundItem;

            if (objetoSeleccionado.GetType().ToString() == "Modelo.Gerente")
            {
                rbnGerente.Checked = true;
               
                Gerente g = new Gerente();
                t = (Trabajador)g;
                t = objetoSeleccionado;

            }
            else if (objetoSeleccionado.GetType().ToString() == "Modelo.Jefe")
            {
                Jefe j = new Jefe();
                t = (Trabajador)j;
                t = objetoSeleccionado;
                rbnJefe.Checked = true;
                btnSuperior.Enabled = true;
            }
            else if (objetoSeleccionado.GetType().ToString() == "Modelo.Comisionista")
            {
                Comisionista c = new Comisionista();
                t = (Trabajador)c;
                t = objetoSeleccionado;

                rbnComisionista.Checked = true;
                btnSuperior.Enabled = true;
            }


            txtNombre.Text = objetoSeleccionado.Nombre;
            txtApellidoMat.Text = objetoSeleccionado.ApellidoMaterno;
            txtApellidoPat.Text = objetoSeleccionado.ApellidoPaterno;
            txtID.Text = objetoSeleccionado.IdTrabajador;
            txtUsuario.Text = objetoSeleccionado.UserName;
            txtContraseña.Text = objetoSeleccionado.Password;
            cmbSede.Text = objetoSeleccionado.Locacion.Distrito;
            txtDNI.Text = objetoSeleccionado.Dni;
            txtIDSuperior.Text = objetoSeleccionado.Superior;
            txtCorreo.Text = objetoSeleccionado.Email;
            dateIngreso.Value = objetoSeleccionado.FechaIngreso;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese datos de un usuario valido");
            }else
            {
                estadoComponentes(Estado.Deshabilitado);
                pnlBusqueda.Visible = false;
                opcion = 3;
                string id_Usuario = logicaTrabajador.gestionarUsuarios(t, txtIDSuperior.Text, 3);
                if (id_Usuario == "Correcto")
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }

           

        }

        private void btnSuperior_Click_1(object sender, EventArgs e)
        {
            if (rbnComisionista.Checked == true)
            {
                frmBuscarSuperior busqSup = new frmBuscarSuperior("JEFE");
                if (busqSup.ShowDialog() == DialogResult.OK)
                {
                    txtIDSuperior.Text = busqSup.ObjetoSeleccionado.IdTrabajador;
                    idSupSup = busqSup.ObjetoSeleccionado.Superior;
                }
               
            } else if (rbnJefe.Checked == true)
            {
                frmBuscarSuperior busqSup = new frmBuscarSuperior("GERENTE");
                if (busqSup.ShowDialog() == DialogResult.OK)
                {
                    txtIDSuperior.Text = busqSup.ObjetoSeleccionado.IdTrabajador;
                }
            }
        }

        private void rbnGerente_Click(object sender, EventArgs e)
        {
            btnSuperior.Enabled = false;
        }

        private void rbnJefe_Click(object sender, EventArgs e)
        {
            btnSuperior.Enabled = true;
        }

        private void rbnComisionista_Click(object sender, EventArgs e)
        {
            btnSuperior.Enabled = true;
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Deshabilitado);
            pnlBusqueda.Visible = false;
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {

            string campo = cmbCampo.Text;
            string filtro = tbFiltro.Text;
            SortableBindingList<Trabajador> listaFiltrada = new SortableBindingList<Trabajador>();
            bool cumple;
            foreach (Trabajador trabajador in listaOriginal)
            {
                switch (campo)
                {
                    case "<Todos>":
                        cumple = trabajador.IdTrabajador.Contains(filtro)
                                || trabajador.Dni.Contains(filtro)
                                || trabajador.Nombre.Contains(filtro)
                                || trabajador.ApellidoPaterno.Contains(filtro)
                                || trabajador.ApellidoMaterno.Contains(filtro)
                                || trabajador.Email.Contains(filtro);
                        break;
                    case "ID Trabajador":
                        cumple = trabajador.IdTrabajador.Contains(filtro);
                        break;
                    case "DNI":
                        cumple = trabajador.Dni.Contains(filtro);
                        break;
                    case "Nombre":
                        cumple = trabajador.Nombre.Contains(filtro);
                        break;
                    case "Apellido Paterno":
                        cumple = trabajador.ApellidoPaterno.Contains(filtro);
                        break;
                    case "Apellido Materno":
                        cumple = trabajador.ApellidoMaterno.Contains(filtro);
                        break;
                    case "Email":
                        cumple = trabajador.Email.Contains(filtro);
                        break;
                    default:
                        cumple = false;
                        break;
                }
                if (!cumple) continue;
                listaFiltrada.Add(trabajador);
            }
            dgvBusqueda.DataSource = listaFiltrada;
            dgvBusqueda.Refresh();
        }

        private void dgvBusqueda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBusqueda.Sort(dgvBusqueda.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

            string texto = txtCorreo.Text + e.KeyChar;
 

            if (texto.Contains('@'))
            {
                int valido = 1;
                foreach (String s in listaCorreos)
                {
                    if (s == texto)
                    {
                        valido = 0;
                        break;
                    }
                }
                if (valido == 0)
                {
                    MensajeCorreo.Visible = true;
                    pictureCheked.Visible = false;
                    validoCorreo = 0;
                } else
                {
                    MensajeCorreo.Visible = false;
                    pictureCheked.Visible = true;
                    validoCorreo = 1;
                }
               
            } else
            {
                MensajeCorreo.Visible = true;
                MensajeCorreo.Text = "Ingrese un correo valido";
                pictureCheked.Visible = false;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
             listaCorreos = logicaTrabajador.listarCorreos();
             listaDni = logicaTrabajador.listarDni();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            string dniP = txtDNI.Text + e.KeyChar;
            int cant = dniP.Length;

            labelDni.Visible = false;
            if (cant == 8)
            {
                int valido = 1;
                foreach (String s in listaDni)
                {
                    
                    if (s == dniP)
                    {
                        valido = 0;
                        break;
                    }
                }
                    if (valido == 0)
                    {
                        labelDni.Visible = true;
                        validoDni = 0;
                    } else
                    {
                        labelDni.Visible = false;
                        validoDni = 1;
                    }
                
            }
        }
    }
}
