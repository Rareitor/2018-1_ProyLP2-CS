﻿using Controlador;
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
    public partial class FrmVisualizarComboProductos : Form
    {
        DateTime fecha;
        ComboBL logicaCombo = new ComboBL();
        ComboProducto objetoSeleccionado = new ComboProducto();

        public FrmVisualizarComboProductos(DateTime fechaVenta)
        {
            InitializeComponent();
            fecha = fechaVenta;
        }

        public ComboProducto ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        private void FrmVisualizarComboProductos_Load(object sender, EventArgs e)
        {
            int mes = fecha.Month;
            int year = fecha.Year;
            string fePeriodo = "";
            if (mes <= 9)
            {
                fePeriodo = year.ToString() + "0" + mes.ToString();
                
            } else
            {
                fePeriodo = year.ToString() + mes.ToString();
            }

           List<ComboProducto> lista = logicaCombo.listarComboProductos(fePeriodo);
            dgvComboProducto.AutoGenerateColumns = false;
            dgvComboProducto.DataSource = lista;
            

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            objetoSeleccionado = (ComboProducto) dgvComboProducto.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvComboProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }
}
