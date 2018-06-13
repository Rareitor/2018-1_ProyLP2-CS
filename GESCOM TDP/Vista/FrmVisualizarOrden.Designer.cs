namespace Vista.Otros
{
    partial class FrmVisualizarOrden
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
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.rdoMensual = new System.Windows.Forms.RadioButton();
            this.rdoDiario = new System.Windows.Forms.RadioButton();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComisionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPdf = new System.Windows.Forms.RadioButton();
            this.rbnExcel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Location = new System.Drawing.Point(47, 21);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(145, 13);
            this.lblTipoReporte.TabIndex = 0;
            this.lblTipoReporte.Text = "Seleccione el tipo de reporte:";
            // 
            // rdoMensual
            // 
            this.rdoMensual.AutoSize = true;
            this.rdoMensual.Location = new System.Drawing.Point(208, 19);
            this.rdoMensual.Name = "rdoMensual";
            this.rdoMensual.Size = new System.Drawing.Size(65, 17);
            this.rdoMensual.TabIndex = 1;
            this.rdoMensual.TabStop = true;
            this.rdoMensual.Text = "Mensual";
            this.rdoMensual.UseVisualStyleBackColor = true;
            // 
            // rdoDiario
            // 
            this.rdoDiario.AutoSize = true;
            this.rdoDiario.Location = new System.Drawing.Point(293, 19);
            this.rdoDiario.Name = "rdoDiario";
            this.rdoDiario.Size = new System.Drawing.Size(52, 17);
            this.rdoDiario.TabIndex = 2;
            this.rdoDiario.TabStop = true;
            this.rdoDiario.Text = "Diario";
            this.rdoDiario.UseVisualStyleBackColor = true;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToOrderColumns = true;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrden,
            this.nombreComisionista,
            this.producto,
            this.Fecha,
            this.Canal,
            this.distrito,
            this.MontoVendido});
            this.dgvRecord.Location = new System.Drawing.Point(50, 178);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.Size = new System.Drawing.Size(788, 332);
            this.dgvRecord.TabIndex = 3;
            this.dgvRecord.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecord_ColumnHeaderMouseClick);
            // 
            // idOrden
            // 
            this.idOrden.DataPropertyName = "Id";
            this.idOrden.HeaderText = "idOrden";
            this.idOrden.Name = "idOrden";
            // 
            // nombreComisionista
            // 
            this.nombreComisionista.DataPropertyName = "NombreTrabajadorCompleto";
            this.nombreComisionista.HeaderText = "Comisionista";
            this.nombreComisionista.MinimumWidth = 150;
            this.nombreComisionista.Name = "nombreComisionista";
            this.nombreComisionista.Width = 150;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "NombreProducto";
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaVenta";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Canal
            // 
            this.Canal.DataPropertyName = "NombreCanal";
            this.Canal.HeaderText = "Canal";
            this.Canal.Name = "Canal";
            // 
            // distrito
            // 
            this.distrito.DataPropertyName = "Distrito";
            this.distrito.HeaderText = "Distrito";
            this.distrito.Name = "distrito";
            // 
            // MontoVendido
            // 
            this.MontoVendido.DataPropertyName = "Monto";
            this.MontoVendido.HeaderText = "MontoVendido";
            this.MontoVendido.Name = "MontoVendido";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(31, 57);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Generar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(763, 575);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(47, 94);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 10;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(47, 55);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(133, 88);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaFin.TabIndex = 8;
            this.dtpFechaFin.Value = new System.DateTime(2018, 6, 30, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(133, 55);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaInicio.TabIndex = 7;
            this.dtpFechaInicio.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(615, 525);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 20);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(695, 525);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPdf);
            this.groupBox1.Controls.Add(this.rbnExcel);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Location = new System.Drawing.Point(638, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // rbnPdf
            // 
            this.rbnPdf.AutoSize = true;
            this.rbnPdf.Location = new System.Drawing.Point(75, 28);
            this.rbnPdf.Name = "rbnPdf";
            this.rbnPdf.Size = new System.Drawing.Size(46, 17);
            this.rbnPdf.TabIndex = 7;
            this.rbnPdf.TabStop = true;
            this.rbnPdf.Text = "PDF";
            this.rbnPdf.UseVisualStyleBackColor = true;
            // 
            // rbnExcel
            // 
            this.rbnExcel.AutoSize = true;
            this.rbnExcel.Location = new System.Drawing.Point(18, 27);
            this.rbnExcel.Name = "rbnExcel";
            this.rbnExcel.Size = new System.Drawing.Size(51, 17);
            this.rbnExcel.TabIndex = 6;
            this.rbnExcel.TabStop = true;
            this.rbnExcel.Text = "Excel";
            this.rbnExcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtrar";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.Enabled = false;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "<Todos>",
            "Comisionista",
            "Producto",
            "Canal",
            "Distrito"});
            this.cbCampo.Location = new System.Drawing.Point(152, 135);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 16;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Enabled = false;
            this.tbFiltro.Location = new System.Drawing.Point(314, 135);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(134, 20);
            this.tbFiltro.TabIndex = 17;
            this.tbFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltro_KeyUp);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Location = new System.Drawing.Point(487, 135);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(43, 23);
            this.buttonBuscar.TabIndex = 18;
            this.buttonBuscar.Text = "...";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(429, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmVisualizarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 623);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.rdoDiario);
            this.Controls.Add(this.rdoMensual);
            this.Controls.Add(this.lblTipoReporte);
            this.Name = "FrmVisualizarOrden";
            this.Text = "Visualizar Record Vendido";
            this.Load += new System.EventHandler(this.FrmVisualizarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.RadioButton rdoMensual;
        private System.Windows.Forms.RadioButton rdoDiario;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComisionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoVendido;
        private System.Windows.Forms.RadioButton rbnPdf;
        private System.Windows.Forms.RadioButton rbnExcel;
    }
}