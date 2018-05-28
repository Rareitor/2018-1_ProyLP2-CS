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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBusqueda = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbGenerales = new System.Windows.Forms.GroupBox();
            this.btnBuscarComisionista = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCombo = new System.Windows.Forms.ComboBox();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDComisionista = new System.Windows.Forms.TextBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.ID_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Comisionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.tsMenu.SuspendLayout();
            this.gbGenerales.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
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
            this.toolStripButton1});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1084, 25);
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
            // gbGenerales
            // 
            this.gbGenerales.Controls.Add(this.btnBuscarComisionista);
            this.gbGenerales.Controls.Add(this.cmbProducto);
            this.gbGenerales.Controls.Add(this.cmbCombo);
            this.gbGenerales.Controls.Add(this.cmbCanal);
            this.gbGenerales.Controls.Add(this.label7);
            this.gbGenerales.Controls.Add(this.txtPago);
            this.gbGenerales.Controls.Add(this.label6);
            this.gbGenerales.Controls.Add(this.dateIngreso);
            this.gbGenerales.Controls.Add(this.label5);
            this.gbGenerales.Controls.Add(this.label3);
            this.gbGenerales.Controls.Add(this.txtID);
            this.gbGenerales.Controls.Add(this.label1);
            this.gbGenerales.Controls.Add(this.label2);
            this.gbGenerales.Controls.Add(this.lblNombre);
            this.gbGenerales.Controls.Add(this.txtIDComisionista);
            this.gbGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbGenerales.Location = new System.Drawing.Point(0, 31);
            this.gbGenerales.Name = "gbGenerales";
            this.gbGenerales.Size = new System.Drawing.Size(433, 284);
            this.gbGenerales.TabIndex = 19;
            this.gbGenerales.TabStop = false;
            this.gbGenerales.Text = "Datos Generales";
            // 
            // btnBuscarComisionista
            // 
            this.btnBuscarComisionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarComisionista.Location = new System.Drawing.Point(378, 89);
            this.btnBuscarComisionista.Name = "btnBuscarComisionista";
            this.btnBuscarComisionista.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarComisionista.TabIndex = 22;
            this.btnBuscarComisionista.Text = "...";
            this.btnBuscarComisionista.UseVisualStyleBackColor = true;
            this.btnBuscarComisionista.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(167, 206);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(204, 23);
            this.cmbProducto.TabIndex = 21;
            // 
            // cmbCombo
            // 
            this.cmbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombo.FormattingEnabled = true;
            this.cmbCombo.Location = new System.Drawing.Point(167, 168);
            this.cmbCombo.Name = "cmbCombo";
            this.cmbCombo.Size = new System.Drawing.Size(204, 23);
            this.cmbCombo.TabIndex = 20;
            // 
            // cmbCanal
            // 
            this.cmbCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(167, 127);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(204, 23);
            this.cmbCanal.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Producto";
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(167, 245);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(204, 26);
            this.txtPago.TabIndex = 16;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monto de Pago:";
            // 
            // dateIngreso
            // 
            this.dateIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateIngreso.Enabled = false;
            this.dateIngreso.Location = new System.Drawing.Point(167, 58);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(204, 26);
            this.dateIngreso.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Combo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 58);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Canal:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(15, 93);
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
            this.pnlBusqueda.Controls.Add(this.btnSeleccionar);
            this.pnlBusqueda.Controls.Add(this.label12);
            this.pnlBusqueda.Controls.Add(this.dgvBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(414, 31);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(636, 327);
            this.pnlBusqueda.TabIndex = 21;
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
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Orden,
            this.ID_Comisionista,
            this.Fecha,
            this.NombreCanal,
            this.Monto});
            this.dgvBusqueda.Location = new System.Drawing.Point(17, 65);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(616, 222);
            this.dgvBusqueda.TabIndex = 0;
            // 
            // ID_Orden
            // 
            this.ID_Orden.DataPropertyName = "Id";
            this.ID_Orden.HeaderText = "ID_Orden";
            this.ID_Orden.Name = "ID_Orden";
            this.ID_Orden.ReadOnly = true;
            this.ID_Orden.Width = 80;
            // 
            // ID_Comisionista
            // 
            this.ID_Comisionista.DataPropertyName = "IdComisionista";
            this.ID_Comisionista.HeaderText = "ID_Comisionista";
            this.ID_Comisionista.Name = "ID_Comisionista";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaVenta";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 140;
            // 
            // NombreCanal
            // 
            this.NombreCanal.DataPropertyName = "NombreCanal";
            this.NombreCanal.HeaderText = "Canal";
            this.NombreCanal.Name = "NombreCanal";
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Location = new System.Drawing.Point(328, 29);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.Size = new System.Drawing.Size(381, 301);
            this.dgvPrueba.TabIndex = 22;
            // 
            // FrmGestionarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 539);
            this.Controls.Add(this.dgvPrueba);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDComisionista;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbCombo;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Button btnBuscarComisionista;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Comisionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvPrueba;
    }
}