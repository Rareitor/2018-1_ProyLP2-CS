using Controlador;
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
    public partial class FrmRanking : Form
    {
        public TrabajadorBL logicaNegocio = new TrabajadorBL();
        public FrmRanking(string tipoUsu, string idPayee)
        {
            InitializeComponent();
            dgvRanking.AutoGenerateColumns = false;
            dgvRanking.AllowUserToAddRows = false;
            dgvRanking.ReadOnly = true;
            dgvRanking.DataSource = logicaNegocio.listarMejoresComisionistas(idPayee);  
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {

        }

        private void dgvRanking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
