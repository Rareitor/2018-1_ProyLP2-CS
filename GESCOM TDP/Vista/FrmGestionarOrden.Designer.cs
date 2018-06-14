namespace Vista
{
    partial class FrmGestionarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarOrden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBusqueda = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnImportar = new System.Windows.Forms.ToolStripButton();
            this.gbGenerales = new System.Windows.Forms.GroupBox();
            this.labelErrorCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarComisionista = new System.Windows.Forms.Button();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDComisionista = new System.Windows.Forms.TextBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.ID_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Comisionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCombo = new System.Windows.Forms.ComboBox();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCombo = new System.Windows.Forms.Button();
            this.tsMenu.SuspendLayout();
            this.gbGenerales.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBusqueda,
            this.btnEliminar,
            this.btnCancelar,
            this.btnImportar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1130, 25);
            this.tsMenu.TabIndex = 18;
            this.tsMenu.Text = "toolStrip2";
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
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(117, 22);
            this.btnImportar.Text = "Importar Archivo";
            this.btnImportar.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // gbGenerales
            // 
            this.gbGenerales.Controls.Add(this.labelErrorCodigo);
            this.gbGenerales.Controls.Add(this.label4);
            this.gbGenerales.Controls.Add(this.txtCodigo);
            this.gbGenerales.Controls.Add(this.btnBuscarComisionista);
            this.gbGenerales.Controls.Add(this.dateIngreso);
            this.gbGenerales.Controls.Add(this.label3);
            this.gbGenerales.Controls.Add(this.txtID);
            this.gbGenerales.Controls.Add(this.label1);
            this.gbGenerales.Controls.Add(this.lblNombre);
            this.gbGenerales.Controls.Add(this.txtIDComisionista);
            this.gbGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerales.Location = new System.Drawing.Point(20, 43);
            this.gbGenerales.Name = "gbGenerales";
            this.gbGenerales.Size = new System.Drawing.Size(422, 175);
            this.gbGenerales.TabIndex = 19;
            this.gbGenerales.TabStop = false;
            this.gbGenerales.Text = "Datos Generales";
            // 
            // labelErrorCodigo
            // 
            this.labelErrorCodigo.AutoSize = true;
            this.labelErrorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCodigo.Location = new System.Drawing.Point(180, 150);
            this.labelErrorCodigo.Name = "labelErrorCodigo";
            this.labelErrorCodigo.Size = new System.Drawing.Size(177, 13);
            this.labelErrorCodigo.TabIndex = 26;
            this.labelErrorCodigo.Text = "La orden ya se encuentra registrada";
            this.labelErrorCodigo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(167, 121);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(204, 26);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // btnBuscarComisionista
            // 
            this.btnBuscarComisionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarComisionista.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarComisionista.Image")));
            this.btnBuscarComisionista.Location = new System.Drawing.Point(381, 88);
            this.btnBuscarComisionista.Name = "btnBuscarComisionista";
            this.btnBuscarComisionista.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarComisionista.TabIndex = 22;
            this.btnBuscarComisionista.Text = "...";
            this.btnBuscarComisionista.UseVisualStyleBackColor = true;
            this.btnBuscarComisionista.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateIngreso
            // 
            this.dateIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateIngreso.Enabled = false;
            this.dateIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateIngreso.Location = new System.Drawing.Point(167, 60);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(204, 23);
            this.dateIngreso.TabIndex = 14;
            this.dateIngreso.ValueChanged += new System.EventHandler(this.dateIngreso_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Venta:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(167, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(204, 26);
            this.txtID.TabIndex = 1;
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(12, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "ID Comisionista:";
            // 
            // txtIDComisionista
            // 
            this.txtIDComisionista.Enabled = false;
            this.txtIDComisionista.Location = new System.Drawing.Point(167, 89);
            this.txtIDComisionista.Name = "txtIDComisionista";
            this.txtIDComisionista.Size = new System.Drawing.Size(204, 26);
            this.txtIDComisionista.TabIndex = 4;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbCampo);
            this.pnlBusqueda.Controls.Add(this.tbFiltro);
            this.pnlBusqueda.Controls.Add(this.btnSeleccionar);
            this.pnlBusqueda.Controls.Add(this.label12);
            this.pnlBusqueda.Controls.Add(this.dgvBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(462, 43);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(635, 382);
            this.pnlBusqueda.TabIndex = 21;
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "<Todos>",
            "ID",
            "ID Comisionista",
            "Codigo",
            "Fecha",
            "Producto"});
            this.cmbCampo.Location = new System.Drawing.Point(17, 59);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(130, 21);
            this.cmbCampo.TabIndex = 4;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(163, 59);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(122, 20);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltro_KeyUp);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(17, 92);
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
            this.label12.Location = new System.Drawing.Point(14, 23);
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
            this.ID_Orden,
            this.Codigo,
            this.ID_Comisionista,
            this.Fecha,
            this.NombreCanal,
            this.Monto});
            this.dgvBusqueda.Location = new System.Drawing.Point(17, 121);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(593, 222);
            this.dgvBusqueda.TabIndex = 0;
            this.dgvBusqueda.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusqueda_ColumnHeaderMouseClick);
            // 
            // ID_Orden
            // 
            this.ID_Orden.DataPropertyName = "Id";
            this.ID_Orden.HeaderText = "ID";
            this.ID_Orden.Name = "ID_Orden";
            this.ID_Orden.ReadOnly = true;
            this.ID_Orden.Width = 70;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 60;
            // 
            // ID_Comisionista
            // 
            this.ID_Comisionista.DataPropertyName = "IdComisionista";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Comisionista.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_Comisionista.HeaderText = "ID Comisionista";
            this.ID_Comisionista.Name = "ID_Comisionista";
            this.ID_Comisionista.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaVenta";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // NombreCanal
            // 
            this.NombreCanal.DataPropertyName = "NombreProducto";
            this.NombreCanal.HeaderText = "Producto";
            this.NombreCanal.Name = "NombreCanal";
            this.NombreCanal.Width = 160;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto (Soles)";
            this.Monto.Name = "Monto";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCombo);
            this.groupBox1.Controls.Add(this.cmbProducto);
            this.groupBox1.Controls.Add(this.cmbCombo);
            this.groupBox1.Controls.Add(this.cmbCanal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 191);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especificaciones";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(170, 109);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(204, 20);
            this.cmbProducto.TabIndex = 31;
            // 
            // cmbCombo
            // 
            this.cmbCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmbCombo.FormattingEnabled = true;
            this.cmbCombo.Location = new System.Drawing.Point(170, 73);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Size = new System.Drawing.Size(204, 20);
            this.cmbCombo.TabIndex = 30;
            // 
            // cmbCanal
            // 
            this.cmbCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(170, 30);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(204, 20);
            this.cmbCanal.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Producto";
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(235, 148);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(139, 26);
            this.txtPago.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Monto de Pago (S/):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Combo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Canal:";
            // 
            // btnCombo
            // 
            this.btnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCombo.Image")));
            this.btnCombo.Location = new System.Drawing.Point(381, 30);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(30, 23);
            this.btnCombo.TabIndex = 27;
            this.btnCombo.Text = "...";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FrmGestionarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.gbGenerales);
            this.Controls.Add(this.tsMenu);
            this.Name = "FrmGestionarOrden";
            this.Text = "Gestionar Órdenes";
            this.Load += new System.EventHandler(this.GestionarOrdenes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGestionarOrden_MouseDown);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbGenerales.ResumeLayout(false);
            this.gbGenerales.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBusqueda;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.GroupBox gbGenerales;
        private System.Windows.Forms.DateTimePicker dateIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDComisionista;
        private System.Windows.Forms.Button btnBuscarComisionista;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.ToolStripButton btnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelErrorCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComboProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbCombo;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Comisionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnCombo;
    }
}