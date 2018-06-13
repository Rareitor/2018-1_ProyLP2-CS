using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Otros;

namespace Vista
{
    public partial class FrmGestionarOrden : Form
    {
        CanalBL logicaCanal = new CanalBL();
        ComboBL logicaCombo = new ComboBL();
        OrdenBL logicaOrden = new OrdenBL();
        ProductoBL logicaProducto = new ProductoBL();
        Orden orden = new Orden();
        Orden objetoSeleccionado = new Orden();
        private BindingList<Orden> listaOriginal;
        private int existeCodigo;
        private SortableBindingList<Orden> listaOrdenada;
        private string tipoOrden = "COMISION";
        private int opcion =1;
        private BindingList<String> listaOrdenCodigo = new BindingList<string>();

        private string tipoUsuario;
        public string idUsuario;
        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }

        public FrmGestionarOrden(string tipoUsu, string idUsuario)
        {
            InitializeComponent();
            tipoUsuario = tipoUsu;
            this.idUsuario = idUsuario;
            llenarComboBox();
            estadoComponentes(Estado.Inicial);
            listaOrdenCodigo = logicaOrden.listarOrdenesCodigo();
            if (tipoUsu == "Comisionista")
            {
                txtIDComisionista.Text = idUsuario;
                btnBuscarComisionista.Enabled = false;
                txtIDComisionista.Enabled = false;
            }
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
                    if (tipoUsuario == "Administrador")
                    {
                        btnBusqueda.Enabled = true;
                    } else
                    {
                        btnBusqueda.Enabled = false;
                    }
                   
                    txtCodigo.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnComboProducto.Enabled = false;
                    btnImportar.Enabled = false;
                    btnBuscarComisionista.Enabled = false;
                    txtID.Enabled = false;
                    txtIDComisionista.Enabled = false;
                    dateIngreso.Enabled = false;
                    txtPago.Enabled = false;
                    cmbCanal.Enabled = false;
                    cmbCombo.Enabled = false;
                    cmbProducto.Enabled = false;
                    pnlBusqueda.Visible = false;
                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    pnlBusqueda.Visible = false;          
                    txtID.Enabled = false;
                    txtCodigo.Enabled = true;
                    btnComboProducto.Enabled = true;
                    if (tipoUsuario != "Comisionista")
                    {
                        txtIDComisionista.Enabled = false;
                        btnBuscarComisionista.Enabled = true;
                    }
                    if (tipoUsuario == "Administrador")
                    {
                        
                       
                        btnBusqueda.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnImportar.Enabled = true;
                    }
                  
                    dateIngreso.Enabled = true;
                    txtPago.Enabled = true;
                    
                    btnCancelar.Enabled = true;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnImportar.Enabled = false;
                    btnGuardar.Enabled = false;
                    if (tipoUsuario == "Administrador")
                    {
                        btnBusqueda.Enabled = true;
                    }
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtID.Enabled = false;
                    btnBuscarComisionista.Enabled = false;
                    txtIDComisionista.Enabled = false;
                    dateIngreso.Enabled = false;
                    txtPago.Enabled = false;
                    btnComboProducto.Enabled = false;
                    cmbCanal.Enabled = false;
                    txtCodigo.Enabled = false;
                    cmbCombo.Enabled = false;
                    cmbProducto.Enabled = false;
                    pnlBusqueda.Visible = false;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            txtID.Text = "";
            if (tipoUsuario != "Comisionista")
            {
                txtIDComisionista.Text = "";
            }
            
            dateIngreso.Value = DateTime.Now;
            txtPago.Text = "";
            txtCodigo.Text = "";

            cmbCanal.SelectedValue = "AD";
            cmbCombo.SelectedValue = "M-MCF";
            cmbProducto.SelectedValue = "CM7ED4";
        }

        private void llenarComboBox()
        {
            BindingList<Canal> ds = logicaCanal.listarCanal();

            cmbCanal.DataSource = ds;
            cmbCanal.DisplayMember = "nombre";
            cmbCanal.ValueMember = "idCanal";
            cmbCanal.SelectedItem = -1;

            BindingList<Combo> listaCombo = logicaCombo.listarCombos();

            cmbCombo.DataSource = listaCombo;
            cmbCombo.DisplayMember = "nombre";
            cmbCombo.ValueMember ="idCombo";
            cmbCombo.SelectedItem = -1;
            BindingList<Producto> listaProducto = logicaProducto.listarProductos();

            cmbProducto.DataSource = listaProducto;
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.SelectedItem = -1;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmGestionarOrdenAdmin gest = new FrmGestionarOrdenAdmin();
            gest.CambiarTextoBoton("Añadir");
            gest.CambiarTextoVentana("Añadir una nueva orden");
            gest.Show();
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmGestionarOrdenAdmin gest = new FrmGestionarOrdenAdmin();
            gest.CambiarTextoBoton("Modificar");
            gest.CambiarTextoVentana("Modificar una orden");
            gest.Show();
        }

        private void GestionarOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmConfirmaBorrar frmConfBorr = new FrmConfirmaBorrar();
            frmConfBorr.Show();
        }

        
        private void tsbtnExportar_Click(object sender, EventArgs e)
        {
            FrmElegirTipoExportar frm = new FrmElegirTipoExportar();
            frm.Show();
        }

        private void tsbtnBusquedaPer_Click(object sender, EventArgs e)
        {
            FrmBusquedaOrdenPersonalizada frmBusPer = new FrmBusquedaOrdenPersonalizada();
            frmBusPer.Show();
        }
        private void pnlIngreseDato_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmGestionarOrden_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDComisionista.Text == "" || txtPago.Text == "" ||
                txtCodigo.Text== "" || existeCodigo == 1) { 
            
                MessageBox.Show("Ingrese una orden valida");
                
            }
            else
            {
                if (DateTime.Compare(dateIngreso.Value, DateTime.Now) > 0)
                {
                    MessageBox.Show("Error en la fecha de registro");
                }
                else
                {
                    orden.FechaVenta = dateIngreso.Value;
                    string idCanal = cmbCanal.SelectedValue.ToString();
                    string idCombo = cmbCombo.SelectedValue.ToString();
                    string idProducto = cmbProducto.SelectedValue.ToString();
                    orden.Canal = new Canal();
                    orden.Canal.IdCanal = idCanal;
                    orden.Canal.Nombre = cmbCanal.Text;
                    orden.Id = txtID.Text;
                    orden.Codigo = txtCodigo.Text;
                    orden.Producto = new Producto();
                    orden.Producto.IdProducto = idProducto;
                    orden.Producto.Nombre = cmbProducto.Text;

                    orden.Combo = new Combo();
                    orden.Combo.IdCombo = idCombo;
                    orden.Combo.Nombre = cmbCombo.Text;
                    orden.Monto = Double.Parse(txtPago.Text);

                    orden.Trabajador = (Trabajador)new Comisionista();
                    orden.Trabajador.IdTrabajador = txtIDComisionista.Text;


                    string respuesta = logicaOrden.gestionarOrden(orden, opcion, tipoOrden);
                    if (respuesta != "Correcta")
                    {
                        txtID.Text = respuesta;
                        MessageBox.Show("Se ha registrado la orden satisfactoriamente");
                    }
                    else if (respuesta == "Correcta")
                    {
                        MessageBox.Show("Se ha actualizado la orden satisfactoriamente");
                    }

                    opcion = 1;
                    estadoComponentes(Estado.Deshabilitado);
                    listaOrdenCodigo = logicaOrden.listarOrdenesCodigo();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tipoUsuario == "Jefe")
            {
                FrmVisualizarUsuario busqUsuario = new FrmVisualizarUsuario("Comisionista", idUsuario, "Jefe", 1);
                if (busqUsuario.ShowDialog() == DialogResult.OK)
                {
                    txtIDComisionista.Text = busqUsuario.ObjetoSeleccionado1.IdTrabajador;

                }
            }
            else if (tipoUsuario == "Administrador")
            {
                FrmVisualizarUsuario busqUsuario = new FrmVisualizarUsuario("Comisionista", idUsuario, "Administrador", 1);
                if (busqUsuario.ShowDialog() == DialogResult.OK)
                {
                    txtIDComisionista.Text = busqUsuario.ObjetoSeleccionado1.IdTrabajador;

                }
            }
            else if (tipoUsuario == "Gerente")
            {
                FrmVisualizarUsuario busqUsuario = new FrmVisualizarUsuario("Comisionista", idUsuario, "Gerente", 1);
                if (busqUsuario.ShowDialog() == DialogResult.OK)
                {
                    txtIDComisionista.Text = busqUsuario.ObjetoSeleccionado1.IdTrabajador;

                }
            }



            else { 
                frmBuscarSuperior busqSup = new frmBuscarSuperior("COMISIONISTA");
                if (busqSup.ShowDialog() == DialogResult.OK)
                {
                    txtIDComisionista.Text = busqSup.ObjetoSeleccionado.IdTrabajador;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        
            if (txtID.Text != "")
            {
                Orden oEliminar = new Orden();
                oEliminar.Id = txtID.Text;
                opcion = 3;
                logicaOrden.gestionarOrden(oEliminar, opcion,tipoOrden);
                MessageBox.Show("La orden ha sido eliminado satisfactoriamente");

           } else {
                MessageBox.Show("Ingrese una orden valida a eliminar");
            }
            estadoComponentes(Estado.Deshabilitado);
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar numeros");
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
           
            listaOriginal = logicaOrden.listarOrden();
            listaOrdenada = new SortableBindingList<Orden>(listaOriginal);
            pnlBusqueda.Visible = true;
 
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = listaOrdenada;
            //pnlBusqueda.Visible = false;
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvBusqueda.Rows.Count == 0) return;
            opcion = 2;
            estadoComponentes(Estado.Nuevo);
            objetoSeleccionado =(Orden) dgvBusqueda.CurrentRow.DataBoundItem;

            txtPago.Text = objetoSeleccionado.Monto.ToString();
            txtIDComisionista.Text = objetoSeleccionado.Trabajador.IdTrabajador;
            txtID.Text = objetoSeleccionado.Id;
            cmbCanal.SelectedValue = objetoSeleccionado.Canal.IdCanal;
            cmbCombo.SelectedValue = objetoSeleccionado.Combo.IdCombo;
            txtCodigo.Text = objetoSeleccionado.Codigo;
            dateIngreso.Value = objetoSeleccionado.FechaVenta;
            cmbProducto.SelectedValue = objetoSeleccionado.Producto.IdProducto;
            tipoOrden = objetoSeleccionado.Producto.Tipo;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            opcion = 1;
            estadoComponentes(Estado.Deshabilitado);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            int encontrado = 0;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel (*.csv)|*.csv";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string ruta = open.FileName;

                    BindingList<Orden> listaCargar = cargarArchivo(ruta);
                    int cantCargadas = 0;
                    foreach (Orden o in listaCargar)
                    {
                        encontrado = 0;
                        foreach(String orden in listaOrdenCodigo)
                        {
                            if (orden == o.Codigo)
                            {
                                encontrado = 1;
                                break;
                            }
                        }
                        if (encontrado == 0)
                        {
                            logicaOrden.GestionarOrden(o, 1, "ARCH");
                            cantCargadas++;
                            listaOrdenCodigo.Add(o.Codigo);
                        }
                        
                    }

                    //Cargar archivo de canales
                    //BindingList<Canal> listaCargar = cargarArchivo2(ruta);
                    //foreach(Canal c in listaCargar)
                    //{
                    //    logicaCanal.cargarCanal(c);
                    //}
                    //Cargar archivos de combos
                    //BindingList<Combo> listaCargar = cargarArchivos3(ruta);
                    //foreach(Combo c in listaCargar)
                    //{
                    //    logicaCombo.cargarCombo(c);
                    //}

                    //BindingList<Producto> listaCargar = cargarArchivos4(ruta);
                    //foreach(Producto p in listaCargar)
                    //{
                    //    logicaProducto.cargarProducto(p);
                    //}
                    MessageBox.Show("Se ha cargado " + cantCargadas + " ordenes");
                }
                MessageBox.Show("Se ha cargado los datos correctamente");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            estadoComponentes(Estado.Deshabilitado);
        }
        private BindingList<Orden> cargarArchivo(string ruta)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string TextLine;
            char delimitador = ',';
            listaOrdenada = new SortableBindingList<Orden>();
            lector.ReadLine();

            while (lector.Peek() != -1)
            {
                Orden o = new Orden();
                TextLine = lector.ReadLine();
                String[] substrings = TextLine.Split(delimitador);
                o.FechaVenta = Convert.ToDateTime(substrings[1]);
                o.Trabajador = new Trabajador();
                o.Trabajador.IdTrabajador = substrings[2];
                o.Canal = new Canal();
                o.Combo = new Combo();
                o.Producto = new Producto();

                o.Canal.IdCanal = substrings[3];
                o.Combo.IdCombo = substrings[4];
                o.Producto.IdProducto = substrings[5];
                o.Producto.Tipo = substrings[6];
                o.Monto = Convert.ToDouble(substrings[7]);
                o.Codigo = substrings[8];
                listaOrdenada.Add(o);
            }

            return listaOrdenada;
        }
        public BindingList<Canal> cargarArchivo2(string ruta)
        {
            BindingList<Canal> lista = new BindingList<Canal>();
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string TextLine;
            char delimitador = ';';
            listaOrdenada = new SortableBindingList<Orden>();
            lector.ReadLine();

            while (lector.Peek() != -1)
            {
                Canal c = new Canal();
                TextLine = lector.ReadLine();
                String[] substrings = TextLine.Split(delimitador);
                c.IdCanal = substrings[0];
                c.Nombre = substrings[1];

                lista.Add(c);
            }

            return lista;
        }
        public BindingList<Combo> cargarArchivos3(string ruta)
        {
            BindingList<Combo> lista = new BindingList<Combo>();
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string TextLine;
            char delimitador = ';';
            listaOrdenada = new SortableBindingList<Orden>();
            lector.ReadLine();

            while (lector.Peek() != -1)
            {
                Combo c = new Combo();
                TextLine = lector.ReadLine();
                String[] substrings = TextLine.Split(delimitador);
                c.IdCombo = substrings[0];
                c.Nombre = substrings[1];
                c.Tipo = substrings[2];

                lista.Add(c);
            }

            return lista;
        }
        public BindingList<Producto> cargarArchivos4(string ruta)
        {
            BindingList<Producto> lista = new BindingList<Producto>();
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string TextLine;
            char delimitador = ';';
            listaOrdenada = new SortableBindingList<Orden>();
            lector.ReadLine();

            while (lector.Peek() != -1)
            {
                Producto p = new Producto();
                TextLine = lector.ReadLine();
                String[] substrings = TextLine.Split(delimitador);
                p.IdProducto = substrings[0];
                p.Nombre = substrings[1];
                p.Tipo = substrings[2];

                lista.Add(p);
            }

            return lista;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            FrmVisualizarComboProductos frmVisualComProd = new FrmVisualizarComboProductos(dateIngreso.Value);

            if (frmVisualComProd.ShowDialog() == DialogResult.OK)
            {
                cmbCanal.SelectedValue = frmVisualComProd.ObjetoSeleccionado.Canal1.IdCanal;
                Console.WriteLine(cmbCanal.SelectedValue);
                cmbCombo.SelectedValue = frmVisualComProd.ObjetoSeleccionado.Combo1.IdCombo;
                Console.WriteLine(cmbCombo.SelectedValue);
                cmbProducto.SelectedValue = frmVisualComProd.ObjetoSeleccionado.Producto.IdProducto;
                Console.WriteLine(cmbProducto.SelectedValue);
                tipoOrden = frmVisualComProd.ObjetoSeleccionado.Producto.Tipo;
            }
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
           if  (dgvBusqueda.RowCount == 1)
            {
                btnSeleccionar.Enabled = false;
            } else
            {
                btnSeleccionar.Enabled = true;
            }
        }

        private void filtrar()
        {
            string campo = cmbCampo.Text;
            string filtro = tbFiltro.Text.ToLower();
            SortableBindingList<Orden> listaFiltrada = new SortableBindingList<Orden>();
            bool cumple;
            foreach (Orden orden in listaOrdenada)
            {
                string nombreMin = orden.NombreProducto.ToLower();
                string codigoMin = orden.Codigo.ToLower();
                string idMin = orden.IdComisionista.ToLower();
                switch (campo)
                {
                    case "<Todos>":
                        cumple = orden.Id.Contains(filtro)
                                || idMin.Contains(filtro)
                                || orden.FechaVenta.ToString().Contains(filtro)
                                || nombreMin.Contains(filtro) ||
                                codigoMin.Contains(filtro);    
                        break;
                    case "ID":
                        cumple = orden.Id.Contains(filtro);
                        break;
                    case "Codigo":
                        cumple = codigoMin.Contains(filtro);
                        break;
                    case "ID Comisionista":
                        cumple = idMin.Contains(filtro);
                        break;
                    case "Fecha":
                        cumple = orden.FechaVenta.ToString().Contains(filtro);
                        break;
                    case "Producto":
                        cumple = nombreMin.Contains(filtro);
                        break;
                    default:
                        cumple = false;
                        break;
                }
                if (!cumple) continue;
                listaFiltrada.Add(orden);
                
            }
            dgvBusqueda.DataSource = listaFiltrada;
            dgvBusqueda.Refresh();
        }

        private void dgvBusqueda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBusqueda.Sort(dgvBusqueda.Columns[e.ColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            existeCodigo = 0;
            string cod = txtCodigo.Text;
            foreach (String o in listaOrdenCodigo)
            {
                if (o == cod)
                {
                    existeCodigo = 1;
                    break;
                }
            }
                if (existeCodigo == 1)
                {
                    labelErrorCodigo.Visible = true;
                } else
                {
                    labelErrorCodigo.Visible = false;
                }
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
