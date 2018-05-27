using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Vista.Otros;
using Controlador;

namespace Vista
{
    public partial class FrmVentanaAdministracion : Form
    {
        private string tipoUsu;
        private string usuarioIngresado;
        private string idPayee;
        private TrabajadorBL logicaTrabajador = new TrabajadorBL();
        public FrmVentanaAdministracion()
        {
            InitializeComponent();
            AbrirFormInPanel(new FrmInicio());
            
        }

        public FrmVentanaAdministracion(string tipoUsuario, string usuario, string id_usuario,
            string nombreUsu, string apellidoPat)
        {
            InitializeComponent();
            AbrirFormInPanel(new FrmInicio());
            this.usuarioIngresado = id_usuario;
            this.tipoUsu = tipoUsuario;
            this.idPayee = id_usuario;
            estadoInicial(tipoUsuario);
            lblCargo.Text = tipoUsuario;
            lblNombreUsu.Text = nombreUsu + " " + apellidoPat;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        
        private void VentanaAdministracion_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lblMenuVertical.Width == 200)
            {
                lblMenuVertical.Width = 65;
                //picLogoTelef2.Visible = true;
                picLogoTelef.Visible = false;
                
            } else
            {
                picLogoTelef.Visible = true;
                //picLogoTelef2.Visible = false;
                lblMenuVertical.Width = 200;
            }
        }

        private void estadoInicial(string usuario)
        {
            switch (usuario)
            {
                case "Administrador":
                    btnGestionarJefeCom.Location = new Point(0, 100);
                    btnCalculoAdmin.Location = new Point(0, 140);
                    btnOtrosJefeCom.Location = new Point(0, 180);
                    btnVisuGere.Hide();
                    break;
                case "Gerente":
                    btnGestionarJefeCom.Location = new Point(0, 100);
                    btnCalculoAdmin.Location = new Point(0, 140);
                    btnOtrosJefeCom.Location = new Point(0, 180);
                    btnVisuGere.Location = new Point(0, 220);
                    break;
                case "Jefe":
                    btnGestionarJefeCom.Location = new Point(0, 100);
                    btnCalculoAdmin.Hide();
                    btnOtrosJefeCom.Location = new Point(0, 140);
                    btnVisuGere.Location = new Point(0, 180);
                    break;
                case "Comisionista":
                    btnGestionarJefeCom.Location = new Point(0, 100);
                    btnCalculoAdmin.Hide();
                    btnOtrosJefeCom.Location = new Point(0, 140);
                    btnVisuGere.Location = new Point(0, 180);
                    break;

            }
        }
        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;

        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;

        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new FrmGestionarOrden());
            pnlGestion.Visible = true;
            pnlCalculo.Visible = false;
            pnlVisualizar.Visible = false;
            pnlOtro.Visible = false;
            //panelMiCuenta.Visible = false;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlGestion.Hide();
            estadoInicial(tipoUsu);
            //pnlGestion.Visible = false;
            AbrirFormInPanel(new FrmGestionarUsuario());
            //pnlCalculo.Visible = false;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            pnlCalculo.Visible = true;
            pnlGestion.Visible = false;
            pnlVisualizar.Visible = false;
            pnlOtro.Visible = false;
            //panelMiCuenta.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlGestion.Hide();
            estadoInicial(tipoUsu);
            //pnlGestion.Visible = false;
            AbrirFormInPanel(new FrmGestionarOrden(tipoUsu, usuarioIngresado));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlGestion.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmGestionarProducto());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlCalculo.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmFijarPeriodoCalculo());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmVisualizarProducto());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlCalculo.Hide();
            estadoInicial(tipoUsu);
            
            MessageBox.Show("Comision calculada");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            
            AbrirFormInPanel(new FrmVisualizarOrden(tipoUsu,idPayee));
        }

        private void button8_Click(object sender, EventArgs e)
        {

            pnlVisualizar.Hide();
            estadoInicial(tipoUsu); 
            AbrirFormInPanel(new FrmVisualizarCanalVenta());
        }


        private void button10_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmVisualizarInfraccion());
        }

        private void button11_Click(object sender, EventArgs e)
        {

            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmNoticias());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Visible = true;
            pnlGestion.Visible = false;
            pnlCalculo.Visible = false;
            pnlOtro.Visible = false;
            //panelMiCuenta.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmPapeleraReciclaje());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmVisualizarRecomendacion());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmRealizarBackup());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmVisualizarMapa());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmReportarInfraccion(usuarioIngresado));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pnlOtro.Hide();
            estadoInicial(tipoUsu);
            AbrirFormInPanel(new FrmAñadirNoticia(usuarioIngresado));
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            pnlOtro.Visible = true;
            pnlVisualizar.Visible = false;
            pnlCalculo.Visible = false;
            pnlGestion.Visible = false;
            //panelMiCuenta.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login= new FrmLogin();
            login.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //panelMiCuenta.Visible = false;
            AbrirFormInPanel(new FrmRecuperarContrasena());
        }

        private void button20_Click(object sender, EventArgs e)
        {
           // panelMiCuenta.Visible = false;
            AbrirFormInPanel(new FrmAdministrarCuenta());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            pnlOtro.Visible = false;
            pnlVisualizar.Visible = false;
            pnlCalculo.Visible = false;
            pnlGestion.Visible = false;
            AbrirFormInPanel(new FrmAdministrarCuenta());
        }

        private void btnOtrosAdmin_Click(object sender, EventArgs e)
        {

        }


        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

      
       



        private void btnGestionarJefeCom_Click(object sender, EventArgs e)
        {
            int cant=3;
            if (pnlGestion.Visible == true)
            {
                pnlGestion.Visible = false;
            } else
            {
                pnlGestion.Visible = true;
            }

            if(pnlGestion.Visible == true)
            {
                btnGestionarJefeCom.Location = new Point(0, 100);
                pnlGestion.Location = new Point(53, 140);
                pnlCalculo.Hide();
                pnlOtro.Hide();
                pnlVisualizar.Hide();

                if (tipoUsu != "Administrador")
                {
                    btnUsuarios.Hide();
                    btnOrdenes.Location = new Point(0, 0);
                    btnProductosGestion.Hide();
                    cant = 1;
                    pnlGestion.Size =   new System.Drawing.Size(150, 25);
                }

                if (tipoUsu == "Gerente" || tipoUsu == "Administrador")
                {
                    btnCalculoAdmin.Location = new Point(0, 140 + cant * 25);
                    btnOtrosJefeCom.Location = new Point(0, 180 + cant * 25);
                    btnVisuGere.Location = new Point(0, 220 + cant * 25);
                } else if (tipoUsu == "Comisionista" || tipoUsu == "Jefe")
                {
                    btnOtrosJefeCom.Location = new Point(0, 140 + cant * 25);
                    btnVisuGere.Location = new Point(0, 180 + cant * 25);
                }
                

            } else {
                estadoInicial(tipoUsu);
            }           

        }

        private void btnOtrosJefeCom_Click(object sender, EventArgs e)
        {
            int cant = 6;
            if (pnlOtro.Visible == true)
            {
                pnlOtro.Visible = false;
            }
            else
            {
                pnlOtro.Visible = true;
            }

            if (pnlOtro.Visible == true)
            {
                btnGestionarJefeCom.Location = new Point(0, 100);
                if (tipoUsu == "Gerente" || tipoUsu =="Administrador")
                {
                    btnCalculoAdmin.Location = new Point(0, 140);
                    btnOtrosJefeCom.Location = new Point(0, 180);
                } else if ((tipoUsu == "Comisionista") || (tipoUsu == "Jefe")){
                    btnOtrosJefeCom.Location = new Point(0, 140);
                }
                
                int yp = btnOtrosJefeCom.Location.Y;

                pnlOtro.Location = new Point(20, yp+50);
           
                pnlCalculo.Hide();
                pnlGestion.Hide();
                pnlVisualizar.Hide();

                if (tipoUsu == "Administrador")
                {
                    btnReportarInfraccion.Hide();
                    btnMapa.Hide();
                    btnAñadirNoticias.Location = new Point(0, 75);
                    pnlOtro.Size = new System.Drawing.Size(180, 100);
                    cant = 4;
                }
                else if (tipoUsu == "Gerente")
                {
                    btnReportarInfraccion.Hide();
                    btnBackup.Hide();
                    btnPapelera.Hide();
                    btnEnviarRecomend.Hide();
                    btnAñadirNoticias.Location = new Point(0, 0);
                    btnMapa.Location = new Point(0, 25);
                    pnlOtro.Size = new System.Drawing.Size(180, 50);
                    cant = 2;
                }
                else if (tipoUsu == "Jefe")
                {
                    btnReportarInfraccion.Hide();
                    btnBackup.Hide();
                    btnPapelera.Hide();
                    btnEnviarRecomend.Hide();
                    btnAñadirNoticias.Location = new Point(0, 0);
                    btnMapa.Hide();
                    pnlOtro.Size = new System.Drawing.Size(180, 25);
                    cant = 1;
                }
                else
                {
                    btnBackup.Hide();
                    btnPapelera.Hide();
                    btnEnviarRecomend.Hide();
                    btnAñadirNoticias.Hide();
                    btnReportarInfraccion.Location = new Point(0, 0);
                    btnMapa.Location = new Point(0, 25);
                    pnlOtro.Size = new System.Drawing.Size(180, 25);
                    cant = 1;
                }

                int yPanel = pnlOtro.Location.Y;
                btnVisuGere.Location = new Point(0, yPanel +10 + cant * 25);

                

            }
            else
            {
                estadoInicial(tipoUsu);
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int cant = 1;
            if (pnlCalculo.Visible == true)
            {
                pnlCalculo.Visible = false;
            }
            else
            {
                pnlCalculo.Visible = true;
            }

            if (pnlCalculo.Visible == true)
            {
                btnGestionarJefeCom.Location = new Point(0, 100);
                btnCalculoAdmin.Location = new Point(0, 140);
                pnlGestion.Hide();
                pnlCalculo.Location = new Point(48, 180);
                pnlOtro.Hide();
                pnlVisualizar.Hide();

                if (tipoUsu == "Administrador")
                {
                    btnComisionCalculo.Hide();
                    pnlCalculo.Size = new System.Drawing.Size(150, 25);
                } else if (tipoUsu == "Gerente")
                {
                    btnFijarPeri.Hide();
                    btnComisionCalculo.Location = new Point(0, 0);
                    pnlCalculo.Size = new System.Drawing.Size(150, 25);
                }

                if (tipoUsu == "Gerente" || tipoUsu == "Administrador")
                {
                    btnOtrosJefeCom.Location = new Point(0, 180 + cant * 25);
                    btnVisuGere.Location = new Point(0, 220 + cant * 25);
                }
                
            }
            else
            {
                estadoInicial(tipoUsu);
            }

        }

        private void pnlPrincipalGerente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPrincipalJefeCom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPersonalCargo_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void btnVisuGere_Click(object sender, EventArgs e)
        {
            
            if (pnlVisualizar.Visible == true)
            {
                pnlVisualizar.Visible = false;
            }
            else
            {
                pnlVisualizar.Visible = true;
            }

            if (pnlVisualizar.Visible == true)
            {
                btnGestionarJefeCom.Location = new Point(0, 100);
              

                if (tipoUsu == "Gerente")
                {
                    btnCalculoAdmin.Location = new Point(0, 140);
                    btnOtrosJefeCom.Location = new Point(0, 180);
                    btnVisuGere.Location = new Point(0, 220);
                }
                else if ((tipoUsu == "Comisionista") || (tipoUsu == "Jefe"))
                {
                    btnOtrosJefeCom.Location = new Point(0, 140);
                    btnVisuGere.Location = new Point(0, 180);
                }

                int yp = btnVisuGere.Location.Y;
                pnlGestion.Hide() ;
                pnlCalculo.Hide();

                pnlOtro.Hide();
                pnlVisualizar.Location = new Point(50,yp+40+10);

                if (tipoUsu == "Gerente")
                {
                    btnJefes.Hide();
                    btnComisionista.Hide();
                } else if (tipoUsu == "Jefe")
                {
                    btnJefes.Hide();
                    btnComisionista.Hide();
                    btnMapa2.Hide();
                    btnInfracciones.Hide();
                    btnNoticiasVisu.Location  = new Point(0, 75);
                    btnPersonalCargo.Location = new Point(0, 100);
                } else if (tipoUsu == "Comisionista")
                {
                    btnPersonalCargo.Hide();
                    btnMapa2.Hide();
                    btnJefes.Hide();
                    btnComisionista.Hide();
                    btnInfracciones.Hide();
                    btnNoticiasVisu.Location = new Point(0, 75);

                }

               

            }
            else
            {
                estadoInicial(tipoUsu);
            }

        
    }

        private void btnPersonalCargo_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Visible = true;
            int yp = btnPersonalCargo.Location.Y;
           // Console.WriteLine(yp.ToString());
            if (tipoUsu == "Gerente")
            {
                btnJefes.Visible = true;
                btnJefes.Location = new Point(30, yp+25);
                btnComisionista.Visible = true;
                btnComisionista.Location = new Point(30,yp+50);
            } else if (tipoUsu == "Jefe")
            {
                btnComisionista.Visible = true;
                btnComisionista.Location = new Point(30, yp+25);
            }
        }

        private void btnMapa2_Click(object sender, EventArgs e)
        {

            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
        }

        private void btnJefes_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            FrmVisualizarUsuario frmVisualizarUsuario = new FrmVisualizarUsuario("Jefe",usuarioIngresado, tipoUsu);
            frmVisualizarUsuario.ocultarSeleccionar();
            AbrirFormInPanel(frmVisualizarUsuario);
        }

        private void btnComisionista_Click(object sender, EventArgs e)
        {
            pnlVisualizar.Hide();
            estadoInicial(tipoUsu);
            FrmVisualizarUsuario frmVisualizarUsuario = new FrmVisualizarUsuario("Comisionista", usuarioIngresado, tipoUsu);
            frmVisualizarUsuario.ocultarSeleccionar();
            AbrirFormInPanel(frmVisualizarUsuario);
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }
    }
}
