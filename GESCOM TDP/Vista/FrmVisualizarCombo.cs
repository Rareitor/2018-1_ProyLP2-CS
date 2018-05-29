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
    public partial class FrmVisualizarCombo : Form
    {
        private  bool papelera;
        private ComboBL logicaNegocio;
        private SortableBindingList<Combo> listaCombo;
        public FrmVisualizarCombo(bool papelera)
        {
            InitializeComponent();
            this.papelera = papelera;
            dgvCombo.AutoGenerateColumns = false;
            logicaNegocio = new ComboBL();
            buscar();
        }

        private void buscar()
        {
            if (!papelera)
            {
                BindingList<Combo> listaCombo = logicaNegocio.listarCombos();
                listaCombo = new SortableBindingList<Combo>(listaCombo);
                dgvCombo.DataSource = listaCombo;
            }
        }
        public bool Papelera { get => papelera; set => papelera = value; }
    }
}
