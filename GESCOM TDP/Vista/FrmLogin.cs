using Controlador;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vista.Otros;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        TrabajadorBL logicaTrabajador = new TrabajadorBL();

        private FrmVentanaAdministracion ven;
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Login2_Load(object sender, EventArgs e)
        {   
            
        }

        private void Login2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int mantenimiento = 0;
            DateTime tiempo = new DateTime();
            logicaTrabajador.mantenimiento(ref mantenimiento, ref tiempo);
            if(mantenimiento == 0)
            {
                FrmRecuperarContrasena rec = new FrmRecuperarContrasena();
                rec.Show();
            }
            else
            {
                MessageBox.Show("SISTEMA GESCOM TDP\n" + "En Mantenimiento hasta el " + tiempo.ToString(), "MANTENIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mantenimiento = 0;
            DateTime tiempo = new DateTime();
            logicaTrabajador.mantenimiento(ref mantenimiento, ref tiempo);

            if(mantenimiento == 0)
            {
                String usuario = txtUsuario.Text;
                String contra = txtContraseña.Text;
                string nombreUsu = "", apellidoPat = "", id_usuario = "";
                int bloqueado = 2;

                if (usuario == "USUARIO")
                {
                    MessageBox.Show("Por favor, ingrese un usuario", "Ingresar usuario");
                    txtUsuario.Text = "USUARIO";
                    txtUsuario.ForeColor = Color.Black;
                    return;
                }
                if (contra == "CONTRASEÑA")
                {
                    if (bloqueado == 1)
                    {
                        MessageBox.Show("Su cuenta se encuentra bloqueada. Por favor comunicarse con el administrador Freddy", "ALERTA");
                    }
                    else
                    {
                        MessageBox.Show("Contraseña errónea, vuelva a ingresar la contraseña");
                    }
                     txtContraseña.Text = "CONTRASEÑA";
                    MessageBox.Show("Por favor, ingrese la contraseña.", "Ingresar contraseña");
                    txtContraseña.Text = "CONTRASEÑA";
                    txtContraseña.ForeColor = Color.Black;
                    txtContraseña.UseSystemPasswordChar = false;
                    return;
                }

                if (usuario != "USUARIO" && contra != "CONTRASEÑA")
                {

                    usuario = usuario.Trim();
                    int existeUsu = 0, errorContra = 0;
                    string respuesta = logicaTrabajador.existeUsuarioyContraseña(usuario, contra, ref existeUsu, ref errorContra,
                        ref id_usuario, ref nombreUsu, ref apellidoPat, ref bloqueado);

                    if (existeUsu == 1 && errorContra == 0 && bloqueado == 0)
                    {
                        ven = new FrmVentanaAdministracion(respuesta, usuario, id_usuario, nombreUsu, apellidoPat);
                        ven.Show();
                        this.Hide();
                    }
                    else if (existeUsu == 1 && errorContra == 1)
                    {
                        

                        MessageBox.Show("Contraseña errónea, vuelva a ingresar la contraseña");

                        if (bloqueado == 1)
                        {
                            MessageBox.Show("Su cuenta se encuentra bloqueada. Por favor comunicarse con el administrador Freddy", "ALERTA");
                        }
                        txtContraseña.Text = "CONTRASEÑA";
                        txtContraseña.ForeColor = Color.Black;
                        txtContraseña.UseSystemPasswordChar = false;
                    }
                    else if (existeUsu == 0)
                    {
                        MessageBox.Show("Por favor, ingrese un usuario válido", "Ingresar usuario");
                        txtUsuario.Text = "USUARIO";
                        txtUsuario.ForeColor = Color.Black;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Su cuenta se encuentra bloqueada. Por favor comunicarse con el administrador Freddy", "ALERTA");
                        txtUsuario.Text = "USUARIO";
                        txtUsuario.ForeColor = Color.Black;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("SISTEMA GESCOM TDP\n"+ "En Mantenimiento hasta el " + tiempo.ToString(), "MANTENIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA")
            {
                
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) button1_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form claves = new Form();
            claves.Text = "Usuarios y claves";
            RichTextBox txt = new RichTextBox();
            txt.Text =
                "Admin:\t\t20090380\tpucp\n" +
                "Gerente:\t\t20176288\troder628\n" +
                "Jefe:\t\t20175863\trodri12\n" +
                "Comisionista:\t20175581\tvictor558";
            txt.Width = 310;
            txt.Height = 70;
            claves.Controls.Add(txt);

            claves.AutoSize = true;
            claves.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            claves.StartPosition = FormStartPosition.Manual;
            claves.Location = new Point(500, 510);
            claves.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) button1_Click(sender, e);
        }
    }
}
