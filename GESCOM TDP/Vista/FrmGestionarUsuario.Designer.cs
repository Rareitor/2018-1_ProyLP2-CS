namespace Vista
{
    partial class FrmGestionarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarUsuario));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBusqueda = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbGenerales = new System.Windows.Forms.GroupBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MensajeCorreo = new System.Windows.Forms.Label();
            this.pictureCheked = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbnGerente = new System.Windows.Forms.RadioButton();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.rbnJefe = new System.Windows.Forms.RadioButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbnComisionista = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSuperior = new System.Windows.Forms.Button();
            this.txtIDSuperior = new System.Windows.Forms.TextBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.ID_Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu.SuspendLayout();
            this.gbGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheked)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBusqueda,
            this.btnEliminar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1087, 25);
            this.tsMenu.TabIndex = 17;
            this.tsMenu.Text = "toolStrip2";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnBusqueda.Image")));
            this.btnBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(133, 22);
            this.btnBusqueda.Text = "Busqueda Avanzada";
            this.btnBusqueda.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // gbGenerales
            // 
            this.gbGenerales.Controls.Add(this.labelDni);
            this.gbGenerales.Controls.Add(this.txtContraseña);
            this.gbGenerales.Controls.Add(this.label7);
            this.gbGenerales.Controls.Add(this.txtUsuario);
            this.gbGenerales.Controls.Add(this.label6);
            this.gbGenerales.Controls.Add(this.dateIngreso);
            this.gbGenerales.Controls.Add(this.txtApellidoMat);
            this.gbGenerales.Controls.Add(this.label5);
            this.gbGenerales.Controls.Add(this.label4);
            this.gbGenerales.Controls.Add(this.txtDNI);
            this.gbGenerales.Controls.Add(this.label3);
            this.gbGenerales.Controls.Add(this.txtID);
            this.gbGenerales.Controls.Add(this.txtApellidoPat);
            this.gbGenerales.Controls.Add(this.label1);
            this.gbGenerales.Controls.Add(this.label2);
            this.gbGenerales.Controls.Add(this.lblNombre);
            this.gbGenerales.Controls.Add(this.txtNombre);
            this.gbGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbGenerales.Location = new System.Drawing.Point(12, 40);
            this.gbGenerales.Name = "gbGenerales";
            this.gbGenerales.Size = new System.Drawing.Size(414, 296);
            this.gbGenerales.TabIndex = 18;
            this.gbGenerales.TabStop = false;
            this.gbGenerales.Text = "Datos Generales";
            this.gbGenerales.Enter += new System.EventHandler(this.gbGenerales_Enter);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelDni.ForeColor = System.Drawing.Color.Red;
            this.labelDni.Location = new System.Drawing.Point(183, 80);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(164, 13);
            this.labelDni.TabIndex = 43;
            this.labelDni.Text = "El DNI ya se encuentra registrado";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(167, 263);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(204, 26);
            this.txtContraseña.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(167, 230);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 26);
            this.txtUsuario.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Usuario:";
            // 
            // dateIngreso
            // 
            this.dateIngreso.Enabled = false;
            this.dateIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateIngreso.Location = new System.Drawing.Point(167, 197);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(204, 23);
            this.dateIngreso.TabIndex = 14;
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.Enabled = false;
            this.txtApellidoMat.Location = new System.Drawing.Point(167, 162);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(204, 26);
            this.txtApellidoMat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(167, 52);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(204, 26);
            this.txtDNI.TabIndex = 10;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Ingreso:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(167, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(204, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.Enabled = false;
            this.txtApellidoPat.Location = new System.Drawing.Point(167, 129);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(204, 26);
            this.txtApellidoPat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(15, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(167, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MensajeCorreo);
            this.groupBox1.Controls.Add(this.pictureCheked);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbnGerente);
            this.groupBox1.Controls.Add(this.cmbSede);
            this.groupBox1.Controls.Add(this.rbnJefe);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbnComisionista);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSuperior);
            this.groupBox1.Controls.Add(this.txtIDSuperior);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(4, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Corporativos:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MensajeCorreo
            // 
            this.MensajeCorreo.AutoSize = true;
            this.MensajeCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MensajeCorreo.ForeColor = System.Drawing.Color.Red;
            this.MensajeCorreo.Location = new System.Drawing.Point(175, 134);
            this.MensajeCorreo.Name = "MensajeCorreo";
            this.MensajeCorreo.Size = new System.Drawing.Size(169, 13);
            this.MensajeCorreo.TabIndex = 42;
            this.MensajeCorreo.Text = "El correo ya se encuentra utilizado";
            // 
            // pictureCheked
            // 
            this.pictureCheked.Image = ((System.Drawing.Image)(resources.GetObject("pictureCheked.Image")));
            this.pictureCheked.Location = new System.Drawing.Point(377, 110);
            this.pictureCheked.Name = "pictureCheked";
            this.pictureCheked.Size = new System.Drawing.Size(24, 22);
            this.pictureCheked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCheked.TabIndex = 41;
            this.pictureCheked.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Sede:";
            // 
            // rbnGerente
            // 
            this.rbnGerente.AutoSize = true;
            this.rbnGerente.Enabled = false;
            this.rbnGerente.Location = new System.Drawing.Point(167, 37);
            this.rbnGerente.Name = "rbnGerente";
            this.rbnGerente.Size = new System.Drawing.Size(86, 24);
            this.rbnGerente.TabIndex = 31;
            this.rbnGerente.TabStop = true;
            this.rbnGerente.Text = "Gerente";
            this.rbnGerente.UseVisualStyleBackColor = true;
            this.rbnGerente.Click += new System.EventHandler(this.rbnGerente_Click);
            // 
            // cmbSede
            // 
            this.cmbSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(167, 155);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(204, 23);
            this.cmbSede.TabIndex = 39;
            // 
            // rbnJefe
            // 
            this.rbnJefe.AutoSize = true;
            this.rbnJefe.Enabled = false;
            this.rbnJefe.Location = new System.Drawing.Point(259, 37);
            this.rbnJefe.Name = "rbnJefe";
            this.rbnJefe.Size = new System.Drawing.Size(58, 24);
            this.rbnJefe.TabIndex = 32;
            this.rbnJefe.TabStop = true;
            this.rbnJefe.Text = "Jefe";
            this.rbnJefe.UseVisualStyleBackColor = true;
            this.rbnJefe.Click += new System.EventHandler(this.rbnJefe_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(167, 106);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(204, 26);
            this.txtCorreo.TabIndex = 38;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCorreo_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Correo:";
            // 
            // rbnComisionista
            // 
            this.rbnComisionista.AutoSize = true;
            this.rbnComisionista.Enabled = false;
            this.rbnComisionista.Location = new System.Drawing.Point(323, 37);
            this.rbnComisionista.Name = "rbnComisionista";
            this.rbnComisionista.Size = new System.Drawing.Size(117, 24);
            this.rbnComisionista.TabIndex = 33;
            this.rbnComisionista.TabStop = true;
            this.rbnComisionista.Text = "Comisionista";
            this.rbnComisionista.UseVisualStyleBackColor = true;
            this.rbnComisionista.Click += new System.EventHandler(this.rbnComisionista_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "ID Superior:";
            // 
            // btnSuperior
            // 
            this.btnSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuperior.Location = new System.Drawing.Point(378, 70);
            this.btnSuperior.Name = "btnSuperior";
            this.btnSuperior.Size = new System.Drawing.Size(53, 26);
            this.btnSuperior.TabIndex = 36;
            this.btnSuperior.Text = "...";
            this.btnSuperior.UseVisualStyleBackColor = true;
            this.btnSuperior.Click += new System.EventHandler(this.btnSuperior_Click_1);
            // 
            // txtIDSuperior
            // 
            this.txtIDSuperior.Enabled = false;
            this.txtIDSuperior.Location = new System.Drawing.Point(167, 70);
            this.txtIDSuperior.Name = "txtIDSuperior";
            this.txtIDSuperior.Size = new System.Drawing.Size(204, 26);
            this.txtIDSuperior.TabIndex = 35;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbCampo);
            this.pnlBusqueda.Controls.Add(this.tbFiltro);
            this.pnlBusqueda.Controls.Add(this.btnSeleccionar);
            this.pnlBusqueda.Controls.Add(this.label12);
            this.pnlBusqueda.Controls.Add(this.dgvBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(451, 50);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(636, 388);
            this.pnlBusqueda.TabIndex = 20;
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "<Todos>",
            "ID Trabajador",
            "DNI",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Email"});
            this.cmbCampo.Location = new System.Drawing.Point(51, 79);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(130, 21);
            this.cmbCampo.TabIndex = 6;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(232, 79);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(122, 20);
            this.tbFiltro.TabIndex = 5;
            this.tbFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltro_KeyUp);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(480, 28);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "RESULTADOS DE BUSQUEDA:";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Trabajador,
            this.DNI,
            this.Nombre,
            this.ApellidoPat,
            this.ApellidoMat,
            this.Email});
            this.dgvBusqueda.Location = new System.Drawing.Point(17, 143);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(616, 222);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusqueda_ColumnHeaderMouseClick);
            // 
            // ID_Trabajador
            // 
            this.ID_Trabajador.DataPropertyName = "IdTrabajador";
            this.ID_Trabajador.HeaderText = "ID_Trabajador";
            this.ID_Trabajador.Name = "ID_Trabajador";
            this.ID_Trabajador.ReadOnly = true;
            this.ID_Trabajador.Width = 80;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "Dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 80;
            // 
            // ApellidoPat
            // 
            this.ApellidoPat.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPat.HeaderText = "Apellido Pat.";
            this.ApellidoPat.Name = "ApellidoPat";
            this.ApellidoPat.ReadOnly = true;
            this.ApellidoPat.Width = 80;
            // 
            // ApellidoMat
            // 
            this.ApellidoMat.DataPropertyName = "ApellidoMaterno";
            this.ApellidoMat.HeaderText = "Apellido Mat.";
            this.ApellidoMat.Name = "ApellidoMat";
            this.ApellidoMat.ReadOnly = true;
            this.ApellidoMat.Width = 80;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 140;
            // 
            // FrmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 603);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGenerales);
            this.Controls.Add(this.tsMenu);
            this.Name = "FrmGestionarUsuario";
            this.Text = "Gestionar Usuarios";
            this.Load += new System.EventHandler(this.FrmGestionarUsuario_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbGenerales.ResumeLayout(false);
            this.gbGenerales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheked)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnBusqueda;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.GroupBox gbGenerales;
        private System.Windows.Forms.DateTimePicker dateIngreso;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSuperior;
        private System.Windows.Forms.TextBox txtIDSuperior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbnComisionista;
        private System.Windows.Forms.RadioButton rbnJefe;
        private System.Windows.Forms.RadioButton rbnGerente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label MensajeCorreo;
        private System.Windows.Forms.PictureBox pictureCheked;
        private System.Windows.Forms.Label labelDni;
    }
}