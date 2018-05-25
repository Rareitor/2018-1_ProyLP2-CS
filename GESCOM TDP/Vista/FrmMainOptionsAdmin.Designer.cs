//namespace Vista
//{
//    partial class FrmMainOptionsAdmin
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.mnsAdmin = new System.Windows.Forms.MenuStrip();
//            this.toolAdministracion = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiGestionarUsuario = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiGestionarOrdenes = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiGestionarProductos = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCalculo = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiFijarPeriodo = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCalculoComisiones = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolVisualizacion = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiMisComisiones = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiProductos = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCanalesVenta = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiPersonalACargo = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiVisualizarJefes = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiVisualizarComisionistas = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiVisualizarGerentes = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiInfracciones = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiNoticias = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolOtros = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiEnviarRecomendaciones = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiPapelera = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiReportarInfraccion = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiVerMapa = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiMiCuenta = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCambiarDatPer = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCambiarContrasena = new System.Windows.Forms.ToolStripMenuItem();
//            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
//            this.mnsAdmin.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // mnsAdmin
//            // 
//            this.mnsAdmin.BackColor = System.Drawing.Color.Navy;
//            this.mnsAdmin.Dock = System.Windows.Forms.DockStyle.Left;
//            this.mnsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.toolAdministracion,
//            this.tsmiCalculo,
//            this.toolVisualizacion,
//            this.toolOtros,
//            this.tsmiMiCuenta,
//            this.tsmiCerrarSesion});
//            this.mnsAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
//            this.mnsAdmin.Location = new System.Drawing.Point(0, 0);
//            this.mnsAdmin.Name = "mnsAdmin";
//            this.mnsAdmin.Size = new System.Drawing.Size(126, 514);
//            this.mnsAdmin.TabIndex = 15;
//            this.mnsAdmin.Text = "menuStrip1";
//            this.mnsAdmin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
//            // 
//            // toolAdministracion
//            // 
//            this.toolAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiGestionarUsuario,
//            this.tsmiGestionarOrdenes,
//            this.tsmiGestionarProductos});
//            this.toolAdministracion.Name = "toolAdministracion";
//            this.toolAdministracion.Size = new System.Drawing.Size(100, 19);
//            this.toolAdministracion.Text = "Administración";
//            this.toolAdministracion.Click += new System.EventHandler(this.toolAdministracion_Click);
//            // 
//            // tsmiGestionarUsuario
//            // 
//            this.tsmiGestionarUsuario.Name = "tsmiGestionarUsuario";
//            this.tsmiGestionarUsuario.Size = new System.Drawing.Size(181, 22);
//            this.tsmiGestionarUsuario.Text = "Gestionar Usuarios";
//            this.tsmiGestionarUsuario.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click_1);
//            // 
//            // tsmiGestionarOrdenes
//            // 
//            this.tsmiGestionarOrdenes.Name = "tsmiGestionarOrdenes";
//            this.tsmiGestionarOrdenes.Size = new System.Drawing.Size(181, 22);
//            this.tsmiGestionarOrdenes.Text = "Gestionar Ordenes";
//            this.tsmiGestionarOrdenes.Click += new System.EventHandler(this.gestionarOrdenesToolStripMenuItem_Click_1);
//            // 
//            // tsmiGestionarProductos
//            // 
//            this.tsmiGestionarProductos.Name = "tsmiGestionarProductos";
//            this.tsmiGestionarProductos.Size = new System.Drawing.Size(181, 22);
//            this.tsmiGestionarProductos.Text = "Gestionar Productos";
//            this.tsmiGestionarProductos.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click_1);
//            // 
//            // tsmiCalculo
//            // 
//            this.tsmiCalculo.BackColor = System.Drawing.Color.Navy;
//            this.tsmiCalculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiFijarPeriodo,
//            this.tsmiCalculoComisiones});
//            this.tsmiCalculo.Image = global::Vista.Properties.Resources.noticias;
//            this.tsmiCalculo.Name = "tsmiCalculo";
//            this.tsmiCalculo.Size = new System.Drawing.Size(75, 20);
//            this.tsmiCalculo.Text = "Cálculo";
//            // 
//            // tsmiFijarPeriodo
//            // 
//            this.tsmiFijarPeriodo.BackColor = System.Drawing.Color.Navy;
//            this.tsmiFijarPeriodo.Name = "tsmiFijarPeriodo";
//            this.tsmiFijarPeriodo.Size = new System.Drawing.Size(197, 22);
//            this.tsmiFijarPeriodo.Text = "Fijar periodo de cálculo";
//            this.tsmiFijarPeriodo.Click += new System.EventHandler(this.fijarPeriodoDeCálculoToolStripMenuItem_Click_1);
//            // 
//            // tsmiCalculoComisiones
//            // 
//            this.tsmiCalculoComisiones.BackColor = System.Drawing.Color.Navy;
//            this.tsmiCalculoComisiones.Name = "tsmiCalculoComisiones";
//            this.tsmiCalculoComisiones.Size = new System.Drawing.Size(197, 22);
//            this.tsmiCalculoComisiones.Text = "Calcular Comisiones";
//            this.tsmiCalculoComisiones.Click += new System.EventHandler(this.calcularComisionesToolStripMenuItem_Click);
//            // 
//            // toolVisualizacion
//            // 
//            this.toolVisualizacion.BackColor = System.Drawing.Color.Navy;
//            this.toolVisualizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiMisComisiones,
//            this.tsmiProductos,
//            this.tsmiCanalesVenta,
//            this.tsmiPersonalACargo,
//            this.tsmiInfracciones,
//            this.tsmiNoticias});
//            this.toolVisualizacion.Name = "toolVisualizacion";
//            this.toolVisualizacion.Size = new System.Drawing.Size(87, 19);
//            this.toolVisualizacion.Text = "Visualización";
//            // 
//            // tsmiMisComisiones
//            // 
//            this.tsmiMisComisiones.BackColor = System.Drawing.Color.Navy;
//            this.tsmiMisComisiones.Name = "tsmiMisComisiones";
//            this.tsmiMisComisiones.Size = new System.Drawing.Size(180, 22);
//            this.tsmiMisComisiones.Text = "Comisiones";
//            this.tsmiMisComisiones.Click += new System.EventHandler(this.misComisionesToolStripMenuItem_Click);
//            // 
//            // tsmiProductos
//            // 
//            this.tsmiProductos.BackColor = System.Drawing.Color.Navy;
//            this.tsmiProductos.Name = "tsmiProductos";
//            this.tsmiProductos.Size = new System.Drawing.Size(180, 22);
//            this.tsmiProductos.Text = "Productos";
//            this.tsmiProductos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
//            // 
//            // tsmiCanalesVenta
//            // 
//            this.tsmiCanalesVenta.Name = "tsmiCanalesVenta";
//            this.tsmiCanalesVenta.Size = new System.Drawing.Size(180, 22);
//            this.tsmiCanalesVenta.Text = "Canales de Venta";
//            this.tsmiCanalesVenta.Click += new System.EventHandler(this.canalesDeVentaToolStripMenuItem_Click);
//            // 
//            // tsmiPersonalACargo
//            // 
//            this.tsmiPersonalACargo.BackColor = System.Drawing.Color.Navy;
//            this.tsmiPersonalACargo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiVisualizarJefes,
//            this.tsmiVisualizarComisionistas,
//            this.tsmiVisualizarGerentes});
//            this.tsmiPersonalACargo.Name = "tsmiPersonalACargo";
//            this.tsmiPersonalACargo.Size = new System.Drawing.Size(180, 22);
//            this.tsmiPersonalACargo.Text = "Personal a Cargo";
//            // 
//            // tsmiVisualizarJefes
//            // 
//            this.tsmiVisualizarJefes.BackColor = System.Drawing.Color.Navy;
//            this.tsmiVisualizarJefes.Name = "tsmiVisualizarJefes";
//            this.tsmiVisualizarJefes.Size = new System.Drawing.Size(180, 22);
//            this.tsmiVisualizarJefes.Text = "Jefes";
//            this.tsmiVisualizarJefes.Click += new System.EventHandler(this.jefesToolStripMenuItem_Click);
//            // 
//            // tsmiVisualizarComisionistas
//            // 
//            this.tsmiVisualizarComisionistas.BackColor = System.Drawing.Color.Navy;
//            this.tsmiVisualizarComisionistas.Name = "tsmiVisualizarComisionistas";
//            this.tsmiVisualizarComisionistas.Size = new System.Drawing.Size(180, 22);
//            this.tsmiVisualizarComisionistas.Text = "Comisionistas";
//            this.tsmiVisualizarComisionistas.Click += new System.EventHandler(this.comisionistaToolStripMenuItem_Click);
//            // 
//            // tsmiVisualizarGerentes
//            // 
//            this.tsmiVisualizarGerentes.BackColor = System.Drawing.Color.Navy;
//            this.tsmiVisualizarGerentes.Name = "tsmiVisualizarGerentes";
//            this.tsmiVisualizarGerentes.Size = new System.Drawing.Size(180, 22);
//            this.tsmiVisualizarGerentes.Text = "Gerentes";
//            this.tsmiVisualizarGerentes.Click += new System.EventHandler(this.gerentesToolStripMenuItem_Click);
//            // 
//            // tsmiInfracciones
//            // 
//            this.tsmiInfracciones.BackColor = System.Drawing.Color.Navy;
//            this.tsmiInfracciones.Name = "tsmiInfracciones";
//            this.tsmiInfracciones.Size = new System.Drawing.Size(180, 22);
//            this.tsmiInfracciones.Text = "Infracciones";
//            this.tsmiInfracciones.Click += new System.EventHandler(this.infraccionesToolStripMenuItem_Click);
//            // 
//            // tsmiNoticias
//            // 
//            this.tsmiNoticias.BackColor = System.Drawing.Color.Navy;
//            this.tsmiNoticias.Name = "tsmiNoticias";
//            this.tsmiNoticias.Size = new System.Drawing.Size(180, 22);
//            this.tsmiNoticias.Text = "Noticias";
//            this.tsmiNoticias.Click += new System.EventHandler(this.noticiasToolStripMenuItem_Click);
//            // 
//            // toolOtros
//            // 
//            this.toolOtros.BackColor = System.Drawing.Color.Navy;
//            this.toolOtros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiEnviarRecomendaciones,
//            this.tsmiPapelera,
//            this.tsmiBackup,
//            this.tsmiReportarInfraccion,
//            this.toolStripMenuItem6,
//            this.toolStripMenuItem4,
//            this.toolStripMenuItem3,
//            this.tsmiVerMapa});
//            this.toolOtros.Name = "toolOtros";
//            this.toolOtros.Size = new System.Drawing.Size(48, 19);
//            this.toolOtros.Text = "Otros";
//            // 
//            // tsmiEnviarRecomendaciones
//            // 
//            this.tsmiEnviarRecomendaciones.BackColor = System.Drawing.Color.Navy;
//            this.tsmiEnviarRecomendaciones.Name = "tsmiEnviarRecomendaciones";
//            this.tsmiEnviarRecomendaciones.Size = new System.Drawing.Size(206, 22);
//            this.tsmiEnviarRecomendaciones.Text = "Enviar Recomendaciones";
//            this.tsmiEnviarRecomendaciones.Click += new System.EventHandler(this.enviarRecomendacionesToolStripMenuItem_Click);
//            // 
//            // tsmiPapelera
//            // 
//            this.tsmiPapelera.BackColor = System.Drawing.Color.Navy;
//            this.tsmiPapelera.Name = "tsmiPapelera";
//            this.tsmiPapelera.Size = new System.Drawing.Size(206, 22);
//            this.tsmiPapelera.Text = "Papelera de Reciclaje";
//            this.tsmiPapelera.Click += new System.EventHandler(this.papeleraDeReciclajeToolStripMenuItem_Click);
//            // 
//            // tsmiBackup
//            // 
//            this.tsmiBackup.BackColor = System.Drawing.Color.Navy;
//            this.tsmiBackup.Name = "tsmiBackup";
//            this.tsmiBackup.Size = new System.Drawing.Size(206, 22);
//            this.tsmiBackup.Text = "Backup";
//            this.tsmiBackup.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
//            // 
//            // tsmiReportarInfraccion
//            // 
//            this.tsmiReportarInfraccion.BackColor = System.Drawing.Color.Navy;
//            this.tsmiReportarInfraccion.Name = "tsmiReportarInfraccion";
//            this.tsmiReportarInfraccion.Size = new System.Drawing.Size(206, 22);
//            this.tsmiReportarInfraccion.Text = "Reportar infracción";
//            this.tsmiReportarInfraccion.Click += new System.EventHandler(this.reportarInfracciónToolStripMenuItem_Click);
//            // 
//            // tsmiVerMapa
//            // 
//            this.tsmiVerMapa.BackColor = System.Drawing.Color.Navy;
//            this.tsmiVerMapa.Name = "tsmiVerMapa";
//            this.tsmiVerMapa.Size = new System.Drawing.Size(206, 22);
//            this.tsmiVerMapa.Text = "Ver Mapa";
//            // 
//            // tsmiMiCuenta
//            // 
//            this.tsmiMiCuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsmiCambiarDatPer,
//            this.tsmiCambiarContrasena});
//            this.tsmiMiCuenta.Name = "tsmiMiCuenta";
//            this.tsmiMiCuenta.Size = new System.Drawing.Size(74, 19);
//            this.tsmiMiCuenta.Text = "Mi Cuenta";
//            // 
//            // tsmiCambiarDatPer
//            // 
//            this.tsmiCambiarDatPer.Name = "tsmiCambiarDatPer";
//            this.tsmiCambiarDatPer.Size = new System.Drawing.Size(211, 22);
//            this.tsmiCambiarDatPer.Text = "Cambiar Datos Personales";
//            this.tsmiCambiarDatPer.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
//            // 
//            // tsmiCambiarContrasena
//            // 
//            this.tsmiCambiarContrasena.Name = "tsmiCambiarContrasena";
//            this.tsmiCambiarContrasena.Size = new System.Drawing.Size(211, 22);
//            this.tsmiCambiarContrasena.Text = "Cambiar Contraseña";
//            this.tsmiCambiarContrasena.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
//            // 
//            // tsmiCerrarSesion
//            // 
//            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
//            this.tsmiCerrarSesion.Size = new System.Drawing.Size(88, 19);
//            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
//            this.tsmiCerrarSesion.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
//            // 
//            // toolStripMenuItem3
//            // 
//            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Navy;
//            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
//            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 22);
//            this.toolStripMenuItem3.Text = "Actualizar Mapa";
//            this.toolStripMenuItem3.Click += new System.EventHandler(this.actualizarMapaToolStripMenuItem_Click);
//            // 
//            // toolStripMenuItem4
//            // 
//            this.toolStripMenuItem4.BackColor = System.Drawing.Color.Navy;
//            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
//            this.toolStripMenuItem4.Size = new System.Drawing.Size(206, 22);
//            this.toolStripMenuItem4.Text = "Backup";
//            this.toolStripMenuItem4.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
//            // 
//            // toolStripMenuItem6
//            // 
//            this.toolStripMenuItem6.BackColor = System.Drawing.Color.Navy;
//            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
//            this.toolStripMenuItem6.Size = new System.Drawing.Size(206, 22);
//            this.toolStripMenuItem6.Text = "Añadir Noticias";
//            this.toolStripMenuItem6.Click += new System.EventHandler(this.añadirNoticiasToolStripMenuItem_Click);
//            // 
//            // FrmMainOptionsAdmin
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
//            this.BackColor = System.Drawing.SystemColors.Control;
//            this.ClientSize = new System.Drawing.Size(904, 514);
//            this.Controls.Add(this.mnsAdmin);
//            this.IsMdiContainer = true;
//            this.MainMenuStrip = this.mnsAdmin;
//            this.MaximizeBox = false;
//            this.Name = "FrmMainOptionsAdmin";
//            this.Text = "Bienvenidos a GESCOM TDP";
//            this.Load += new System.EventHandler(this.frmMainOptionsAdmin_Load);
//            this.mnsAdmin.ResumeLayout(false);
//            this.mnsAdmin.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.MenuStrip mnsAdmin;
//        private System.Windows.Forms.ToolStripMenuItem toolAdministracion;
//        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarUsuario;
//        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarOrdenes;
//        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarProductos;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCalculo;
//        private System.Windows.Forms.ToolStripMenuItem tsmiFijarPeriodo;
//        private System.Windows.Forms.ToolStripMenuItem toolVisualizacion;
//        private System.Windows.Forms.ToolStripMenuItem toolOtros;
//        private System.Windows.Forms.ToolStripMenuItem tsmiEnviarRecomendaciones;
//        private System.Windows.Forms.ToolStripMenuItem tsmiPapelera;
//        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
//        private System.Windows.Forms.ToolStripMenuItem tsmiMisComisiones;
//        private System.Windows.Forms.ToolStripMenuItem tsmiProductos;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCanalesVenta;
//        private System.Windows.Forms.ToolStripMenuItem tsmiMiCuenta;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarDatPer;
//        private System.Windows.Forms.ToolStripMenuItem tsmiReportarInfraccion;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCalculoComisiones;
//        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalACargo;
//        private System.Windows.Forms.ToolStripMenuItem tsmiVisualizarJefes;
//        private System.Windows.Forms.ToolStripMenuItem tsmiVisualizarComisionistas;
//        private System.Windows.Forms.ToolStripMenuItem tsmiInfracciones;
//        private System.Windows.Forms.ToolStripMenuItem tsmiNoticias;
//        private System.Windows.Forms.ToolStripMenuItem tsmiCambiarContrasena;
//        private System.Windows.Forms.ToolStripMenuItem tsmiVerMapa;
//        private System.Windows.Forms.ToolStripMenuItem tsmiVisualizarGerentes;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
//        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
//    }
//}