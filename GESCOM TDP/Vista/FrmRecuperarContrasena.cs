using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Otros
{
    public partial class FrmRecuperarContrasena : Form
    {
        TrabajadorBL logicaTrabajador = new TrabajadorBL();
        Trabajador t = new Trabajador();

        public FrmRecuperarContrasena()
        {
            InitializeComponent();
            txtRespuesta.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if(txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su correo electrónico");
            }
            else
            {
                t = logicaTrabajador.correoycontaseña(txtUsuario.Text);
                if (t == null)
                {
                    //txtRespuesta.Visible = true;
                    MessageBox.Show("El usuario no existe");
                } else if (txtUsuario.Text == t.UserName)
                {
                    enviarMensaje(t);
                    //txtRespuesta.Visible = true;
                    MessageBox.Show( "Se ha enviado su contraseña a su correo " +
                        t.Email + ". Por favor revise su bandeja de entrada");
                    this.Close();
                }
                
                
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enviarMensaje (Trabajador t)
        {
            MailMessage Correo = new MailMessage();

            Correo.From = new MailAddress("grupo8lp2@gmail.com");
            Correo.To.Add(t.Email);
            Correo.Subject = ("Recuperar Contraseña");
            Correo.Body = "Hola, " + t.Nombre + " " + t.ApellidoPaterno +
                ":\n Usted solicitó recuperar contraseña.\n Su contraseña es: " + t.Password;
            Correo.Priority = MailPriority.Normal;
            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587; //465; //587
            ServerMail.Credentials = new NetworkCredential("grupo8lp2@gmail.com", "pucppucp");
            ServerMail.EnableSsl = true;

            try
            {
                ServerMail.Send(Correo);
            }
            catch (Exception )
            {
                //throw new Exception("No se ha podido enviar el email", ex.InnerException);
            }
            finally
            {
                Correo.Dispose();
                ServerMail.Dispose();

            }

        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
