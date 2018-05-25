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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if(txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su correo electrónico");
            }
            else
            {
                t = logicaTrabajador.correoycontaseña(txtCorreo.Text);
                if (t == null)
                {
                    MessageBox.Show("El correo no se encuentra registrado");
                } else if (txtCorreo.Text == t.Email)
                {
                    enviarMensaje(t);
                    MessageBox.Show("Su contraseña se ha enviado satisfactoriamente al correo");
                }
                
                
                
                this.Close();
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
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

            mail.From = new MailAddress("oscar.ashtu@pucp.pe");

            mail.To.Add(t.Email);
            mail.Subject = "Envio de Contraseña - Sistema GESCOM TDP";
            mail.Body = "Estimado(a) " + t.ApellidoPaterno + " ,su contraseña es: " + t.Password;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25; //465; //587
            smtp.Credentials = new NetworkCredential("oscar.ashtu@pucp.edu.pe", "****");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception )
            {
                //throw new Exception("No se ha podido enviar el email", ex.InnerException);
            }
            finally
            {
                smtp.Dispose();
            }

        }
    }
}
