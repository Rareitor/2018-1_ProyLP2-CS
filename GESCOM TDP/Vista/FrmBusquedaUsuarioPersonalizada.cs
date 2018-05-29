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
    public partial class FrmBusquedaUsuarioPersonalizada : Form
    {
        TrabajadorBL logicaTrabajador = new TrabajadorBL();
        private string dni;
        private string nombre;
        private string apellidoPat;
        private string apellidoMat;
        private string correo;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPat { get => apellidoPat; set => apellidoPat = value; }
        public string ApellidMat { get => apellidoMat; set => apellidoMat = value; }
        public string Correo { get => correo; set => correo = value; }

        public FrmBusquedaUsuarioPersonalizada()
        {
            
            InitializeComponent();
            BindingList<String> listaApellidoMat = logicaTrabajador.listarCampos("", "", "X", "", "");
            BindingList<String> listaApellidoPat = logicaTrabajador.listarCampos("", "X", "", "", "");
            BindingList<String> listaDNI = logicaTrabajador.listarCampos("", "", "", "", "X");
            BindingList<String> listaCorreo = logicaTrabajador.listarCampos("", "", "", "X", "");
            BindingList<String> listaNombre = logicaTrabajador.listarCampos("X", "", "", "", "");
                       
            llenarComboBox(cmbApellidoMaterno,listaApellidoMat);
            llenarComboBox(cmbApellidoPaterno, listaApellidoPat);
            llenarComboBox(cmbCorreo, listaCorreo);
            llenarComboBox(cmbNombre, listaNombre);
            llenarComboBox(cmbDNI, listaDNI);
        }

        public FrmBusquedaUsuarioPersonalizada(BindingList<Trabajador> lista)
        {

            InitializeComponent();
            BindingList<String> listaApellidoMat = new BindingList<string>();
            BindingList<String> listaApellidoPat = new BindingList<string>();
            BindingList<String> listaDNI = new BindingList<string>();
            BindingList<String> listaCorreo = new BindingList<string>();
            BindingList<String> listaNombre = new BindingList<string>();

            foreach (Trabajador t in lista)
            {
                //int esta;
                //foreach (String s in listaApellidoMat)
                //{
                //    if (s == t.ApellidoMaterno)
                //    {
                //        esta = 1;
                //    } else
                //    {
                //        esta = 0;
                //    }
                //}
                listaApellidoMat.Add(t.ApellidoMaterno);

                listaApellidoPat.Add(t.ApellidoPaterno);
                listaDNI.Add(t.Dni);
                listaCorreo.Add(t.Email);
                listaNombre.Add(t.Nombre);
                

            }
            
            llenarComboBox(cmbApellidoMaterno, listaApellidoMat);
            llenarComboBox(cmbApellidoPaterno, listaApellidoPat);
            llenarComboBox(cmbCorreo, listaCorreo);
            llenarComboBox(cmbNombre, listaNombre);
            llenarComboBox(cmbDNI, listaDNI);
        }

        public void llenarComboBox(ComboBox cmb, BindingList<String> listar)
        {
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            BindingList<String> lista = new BindingList<string>();
            lista = listar;
            for (int i=0; i < listar.Count; i++)
            {
                datos.Add(lista[i]);
            }
            cmb.AutoCompleteCustomSource = datos;
            cmb.DataSource = datos;
            cmb.SelectedIndex = -1;

        }
        private void FrmBusquedaUsuarioPersonalizada_Load(object sender, EventArgs e)
        {

        }

        private void cmbIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CLICK DE BUSCAR
            if (chckNombre.Checked == true)
            {
                nombre = cmbNombre.Text;
            }
           
            if (chkApellidoMaterno.Checked== true)
            {
                apellidoMat = cmbApellidoMaterno.Text;
            }
           
            if (chkApellidoPaterno.Checked == true)
            {
                apellidoPat = cmbApellidoPaterno.Text;

            }
            if (chkCorreo.Checked== true)
            {
                correo = cmbCorreo.Text;
            }
           
            if (chkDni.Checked== true)
            {
                dni = cmbDNI.Text;
            }
            

            this.DialogResult = DialogResult.OK;
        }

        private void cmbCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbDNI_Click(object sender, EventArgs e)
        {

            
        }

        private void chckNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chckNombre.Checked == true)
            {
                cmbCorreo.Enabled = false;
                cmbDNI.Enabled = false;
                chkCorreo.Enabled = false;
                chkDni.Enabled = false;
                cmbNombre.Enabled = true;
            } else
            {
                cmbNombre.Enabled = false;

                if (chkApellidoPaterno.Checked == false && chkApellidoMaterno.Checked == false && chckNombre.Checked == false)
                {
                    chkCorreo.Enabled = true;
                    chkDni.Enabled = true;
                }


            }
        }

        private void chkDni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDni.Checked == true)
            {
                cmbDNI.Enabled = true;
                chkApellidoMaterno.Enabled = false;
                chkApellidoPaterno.Enabled = false;
                chkCorreo.Enabled = false;
                chckNombre.Enabled = false;

            }
            else
            {
                chckNombre.Enabled = true;
                chkCorreo.Enabled = true;
                chkApellidoMaterno.Enabled = true;
                chkApellidoPaterno.Enabled = true;
                cmbDNI.Enabled = false;
            }
        }

        private void chkCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCorreo.Checked == true)
            {
                cmbCorreo.Enabled = true;
                chkApellidoMaterno.Enabled = false;
                chkApellidoPaterno.Enabled = false;
                chkDni.Enabled = false;
                chckNombre.Enabled = false;

            }
            else
            {
                chckNombre.Enabled = true;
                chkDni.Enabled = true;
                chkApellidoMaterno.Enabled = true;
                chkApellidoPaterno.Enabled = true;
                cmbCorreo.Enabled = false;
            }
        }

        private void chkApellidoPaterno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApellidoPaterno.Checked == true)
            {
                cmbCorreo.Enabled = false;
                cmbDNI.Enabled = false;
                chkCorreo.Enabled = false;
                chkDni.Enabled = false;
                cmbApellidoPaterno.Enabled = true;
            }
            else
            {
                cmbApellidoPaterno.Enabled = false;
                if (chkApellidoPaterno.Checked == false && chkApellidoMaterno.Checked == false && chckNombre.Checked == false)
                {
                    chkCorreo.Enabled = true;
                    chkDni.Enabled = true;
                }
            }
        }

        private void chkApellidoMaterno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApellidoMaterno.Checked == true)
            {
                cmbCorreo.Enabled = false;
                cmbDNI.Enabled = false;
                cmbApellidoMaterno.Enabled = true;

                chkCorreo.Enabled = false;
                chkDni.Enabled = false;
            }
            else
            {
                cmbApellidoMaterno.Enabled = false;
                if (chkApellidoPaterno.Checked == false && chkApellidoMaterno.Checked == false && chckNombre.Checked == false)
                {
                    chkCorreo.Enabled = true;
                    chkDni.Enabled = true;
                }
                
            }
        }
    }
}
