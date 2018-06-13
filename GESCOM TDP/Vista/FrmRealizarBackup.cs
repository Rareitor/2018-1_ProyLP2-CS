using Controlador;
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

namespace Vista.Otros
{
    public partial class FrmRealizarBackup : Form
    {
        TrabajadorBL logicaTrabajador = new TrabajadorBL();
        public FrmRealizarBackup()
        {
            InitializeComponent();
            int mantenimiento = 0;
            DateTime tiempo = new DateTime();
            logicaTrabajador.mantenimiento(ref mantenimiento, ref tiempo);
            if(mantenimiento == 1)
            {
                dateIngreso.Enabled = false;
                dateIngreso.Text = tiempo.ToString();
                btnCancelar.Text = "Terminar";
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(btnCancelar.Text == "Registrar"){
                DialogResult dialogResult = MessageBox.Show("Seguro de registrar mantenimiento", "Mantenimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if(dateIngreso.Value >= DateTime.Now)
                    {
                        logicaTrabajador.PonerMantenimiento(1, dateIngreso.Value);
                        MessageBox.Show("Mantenimiento hasta el " + dateIngreso.Value.ToString("dd/MM/yyyy"), "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dateIngreso.Enabled = false;
                        btnCancelar.Text = "Terminar";
                    }
                    else
                    {
                        MessageBox.Show("Fecha inválida", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                
                logicaTrabajador.PonerMantenimiento(0, dateIngreso.Value);
                MessageBox.Show("Mantenimiento terminado", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateIngreso.Enabled = true;
                btnCancelar.Text = "Registrar";
            }
            
        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIngreseUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void dateIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
