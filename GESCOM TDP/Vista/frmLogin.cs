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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textBoxContrasena.PasswordChar = '*';
        }


        private void linkOlvideContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String puesto = textBoxUsuario.Text;
            if (puesto == "") puesto = "Gerente";

            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un usuario válido.", "Ingresar usuario");
            }
            else if (textBoxContrasena.Text == "")
            {
                MessageBox.Show("Por favor, ingrese la contraseña.", "Ingresar contraseña");
            }

            //this.Hide();
            switch (puesto)
            {
                case ("Administrador"):
                    frmMainOptionsAdmin frmAdmin = new frmMainOptionsAdmin();
                    frmAdmin.Show();
                    break;
                case ("Gerente"):
                    frmMainOptionsGerente frmGerente = new frmMainOptionsGerente();
                    frmGerente.ShowDialog();
                    break;
                case ("Jefe"):
                    frmMainOptionsJefe frmJefe = new frmMainOptionsJefe();
                    frmJefe.ShowDialog();
                    break;
                case ("Comisionista"):
                    frmMainOptionsComisionista frmComisionita = new frmMainOptionsComisionista();
                    frmComisionita.ShowDialog();
                    break;
            }       
        }

        private void textBoxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) buttonLogin_Click(sender, e);
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) buttonLogin_Click(sender, e);
            
        }
    }
}
