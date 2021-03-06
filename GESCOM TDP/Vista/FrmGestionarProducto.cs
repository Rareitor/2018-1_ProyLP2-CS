﻿using Controlador;
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
using Vista.Otros;

namespace Vista
{
    public partial class FrmGestionarComboProducto : Form
    {
        CanalBL logicaCanal = new CanalBL();
        ComboBL logicaCombo = new ComboBL();
        OrdenBL logicaOrden = new OrdenBL();
        ProductoBL logicaProducto = new ProductoBL();
        BindingList<String> listaComision = new BindingList<string>();
        BindingList<String> listaPenalidad = new BindingList<string>();
        BindingList<String> listaBono= new BindingList<string>();

        ComboProducto cProducto = new ComboProducto();
        public enum Estado
        {
            Inicial, Nuevo, Deshabilitado
        }


        public FrmGestionarComboProducto()
        {
            InitializeComponent();
            llenarComboBox();
            estadoComponentes(Estado.Inicial);
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    cmbMesPeriodo.Enabled = false;
                    cmbAñoPeriodo.Enabled = false;
                    rbnBono.Enabled = false;
                    rbnComision.Enabled = false;
                    rbnPenalidad.Enabled = false;
                    btnImportar.Visible = false;

                    btnImportar.Enabled = false;
                    btnCancelar.Enabled = false;
                    cmbCanal.Enabled = false;
                    cmbCombo.Enabled = false;
                    cmbProducto.Enabled = false;
                    limpiarComponentes();
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnImportar.Enabled = true;
                    cmbCanal.Enabled = true;
                    cmbCombo.Enabled = true;
                    cmbProducto.Enabled = true;
                    btnCancelar.Enabled = true;
                    //rbnBono.Enabled = true;
                    //rbnComision.Enabled = true;
                    //rbnPenalidad.Enabled = true;
                    //rbnComision.Checked = true;
                    cmbMesPeriodo.Enabled = true;
                    cmbAñoPeriodo.Enabled = true;
                    limpiarComponentes();
                    break;
                case Estado.Deshabilitado:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //rbnBono.Enabled = false;
                    //rbnComision.Enabled = false;
                    //rbnPenalidad.Enabled = false;
                    cmbMesPeriodo.Enabled = false;
                    cmbAñoPeriodo.Enabled = false;
                    cmbCanal.Enabled = false;
                    cmbCombo.Enabled = false;
                    cmbProducto.Enabled = false;
                    break;
            }
        }
        public void limpiarComponentes()
        {
            cmbMesPeriodo.SelectedItem = -1;
            cmbAñoPeriodo.SelectedItem = -1;
            cmbCanal.SelectedItem = -1;
            cmbCombo.SelectedItem = -1;
            cmbProducto.SelectedItem = -1;
        }

        private void llenarComboBox()
        {
            BindingList<Canal> ds = logicaCanal.listarCanal();

            cmbCanal.DataSource = ds;
            cmbCanal.DisplayMember = "nombre";
            cmbCanal.ValueMember = "idCanal";

            BindingList<Combo> listaCombo = logicaCombo.listarCombos(ref listaComision, ref listaBono, ref  listaPenalidad);

            cmbCombo.DataSource = listaCombo;
            cmbCombo.DisplayMember = "nombre";
            cmbCombo.ValueMember = "idCombo";

            BindingList<Producto> listaProducto = logicaProducto.listarProductos();

            cmbProducto.DataSource = listaProducto;
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "idProducto";



        }
        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void GestionarProductos_Load(object sender, EventArgs e)
        {

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnExportar_Click(object sender, EventArgs e)
        {
            FrmElegirTipoExportar frm = new FrmElegirTipoExportar();
            frm.Show();
        }


        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            FrmConfirmaBorrar frmConfBorr = new FrmConfirmaBorrar();
            frmConfBorr.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mesPe = cmbMesPeriodo.Text;
            if (cmbAñoPeriodo.Text == ""||cmbMesPeriodo.Text == "")
            {
                MessageBox.Show("Ingrese un combo producto correcto");
                return;

            }
            int yearPeriodo = Int32.Parse(cmbAñoPeriodo.Text);
            int mesPeriodo=6;
      
            switch (mesPe)
            {
                case "Enero": mesPeriodo = 1; break;
                case "Febrero": mesPeriodo = 2; break;
                case "Marzo": mesPeriodo = 3; break;
                case "Abril": mesPeriodo = 4; break;
                case "Mayo": mesPeriodo = 5; break;
                case "Junio": mesPeriodo = 6; break;
                case "Julio": mesPeriodo = 7; break;
                case "Agosto": mesPeriodo = 8; break;
                case "Septiembre": mesPeriodo = 9; break;
                case "Octubre": mesPeriodo = 10; break;
                case "Noviembre": mesPeriodo = 11; break;
                case "Diciembre": mesPeriodo = 12; break;
            }
            string fePeriodo = "";
            if (mesPeriodo <= 9)
            {
                fePeriodo = yearPeriodo.ToString() + "0" + mesPeriodo;

            }
            else if (mesPeriodo >= 10)
            {
                fePeriodo = yearPeriodo.ToString()  + mesPeriodo;
            }
            

            if (rbnComision.Checked == true)
            {
                cProducto.Tipo = "COMISION";
            } else if (rbnPenalidad.Checked == true)
            {
                cProducto.Tipo = "PENALIDAD";
            } else if (rbnBono.Checked == true)
            {
                cProducto.Tipo = "BONO";
            }

            //VERIFICAR SI YA EXISTE EL COMBO PRODUCTO EN LA FECHA DETERMINADA
            List<ComboProducto> listaActualizada = logicaCombo.listarComboProductos(fePeriodo);
            

            DateTime fechaInicio = new DateTime(yearPeriodo,mesPeriodo, 1);
            DateTime fechaFin = new DateTime(yearPeriodo, mesPeriodo+ 1, 1).AddDays(-1);

            string idCanal = cmbCanal.SelectedValue.ToString();
            string idCombo = cmbCombo.SelectedValue.ToString();
            string idProducto = cmbProducto.SelectedValue.ToString();
            cProducto.Canal1 = new Canal();
            cProducto.Canal1.IdCanal = idCanal;
            cProducto.Canal1.Nombre = cmbCanal.Text;

            cProducto.Producto = new Producto();
            cProducto.Producto.IdProducto = idProducto;
            cProducto.Producto.Nombre = cmbProducto.Text;

            cProducto.Combo1 = new Combo();
            cProducto.Combo1.IdCombo = idCombo;
            cProducto.Combo1.Nombre = cmbCombo.Text;
            cProducto.FePeriodo = fePeriodo;
            cProducto.FechaInicio1 = fechaInicio;
            cProducto.FechaFin1 = fechaFin;

            int existeComboProd = 0;
            foreach (ComboProducto cm in listaActualizada)
            {
                if (cm.Canal1.IdCanal == idCanal && cm.Combo1.IdCombo == idCombo && cm.Producto.IdProducto == idProducto)
                {
                    existeComboProd = 1;
                    break;
                }

            }

            if (existeComboProd == 0)
            {
                string rpta = logicaCombo.agregarComboProducto(cProducto);
                if (rpta == "Correcto")
                {
                    MessageBox.Show("Se ha agregado correctamente el combo producto");

                    estadoComponentes(Estado.Deshabilitado);
                }
            } else
            {
                MessageBox.Show("El combo producto ya se encuentra registrado");
            }


            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Deshabilitado);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel (*.csv)|*.csv";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string ruta = open.FileName;

                    BindingList<ComboProducto> listaCargar = cargarArchivo(ruta);

                    foreach (ComboProducto o in listaCargar)
                    {
                        logicaCombo.agregarComboProducto(o);
                    }


                }
                MessageBox.Show("Se ha cargado los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private SortableBindingList<ComboProducto> listaOrdenada;
        private BindingList<ComboProducto> cargarArchivo(string ruta)
        {
            
              FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string TextLine;
            char delimitador = ';';
            listaOrdenada = new SortableBindingList<ComboProducto>();
            lector.ReadLine();

            while (lector.Peek() != -1)
            {
                ComboProducto cp = new ComboProducto();
                TextLine = lector.ReadLine();
                String[] substrings = TextLine.Split(delimitador);
                cp.FechaFin1 = Convert.ToDateTime(substrings[3]) ;
                cp.FechaInicio1 = Convert.ToDateTime(substrings[4]); ;
                cp.Canal1 = new Canal();
                cp.Canal1.IdCanal = substrings[2];
                cp.FePeriodo = substrings[5];
                cp.Tipo = substrings[6];
                cp.Formula = Convert.ToInt32(substrings[7]);
                cp.Combo1 = new Combo();
                cp.Combo1.IdCombo = substrings[1];
                cp.Producto = new Producto();
                cp.Producto.IdProducto = substrings[0];
                listaOrdenada.Add(cp);
            }

            return listaOrdenada;
        }

        private void cmbMesPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string idCombo = cmbCombo.SelectedValue.ToString();
            int encontrado = 0;
            string tip = "";
            foreach (String s in listaComision)
            {
                if (s == idCombo)
                {
                    encontrado = 1;
                    tip = "COMISION";
                    break;
                }
            }

            if (encontrado == 0)
            {
                foreach (String s in listaPenalidad)
                {
                    if (s == idCombo)
                    {
                        encontrado = 1;
                        tip = "PENALIDAD";
                        break;
                    }
                }
            }

            if (encontrado == 0)
            {
                foreach (String s in listaBono)
                {
                    if (s == idCombo)
                    {
                        encontrado = 1;
                        tip = "BONO";
                        break;
                    }
                }
            }

            if (tip == "COMISION")
            {
                rbnComision.Checked = true;
                rbnBono.Checked = false;
                rbnPenalidad.Checked = false;
            } else if (tip == "BONO")
            {
                rbnComision.Checked = false;
                rbnBono.Checked = true;
                rbnPenalidad.Checked = false;
            } else
            {
                rbnComision.Checked = false;
                rbnBono.Checked = false;
                rbnPenalidad.Checked = true;
            }


            BindingList<Producto> listaProducto = logicaProducto.listarProductos2(tip);

            cmbProducto.DataSource = listaProducto;
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "idProducto";
        }
    }
}
