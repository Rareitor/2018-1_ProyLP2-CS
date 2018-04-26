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
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
            if (Owner is frmMainOptionsAdmin)
            {
                //source -> Adminstrador
            };
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
