namespace Vista.Otros
{
    partial class FrmVisualizarRecordVendido
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComisionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvRecord.Size = new System.Drawing.Size(778, 329);
            this.dgvRecord.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(31, 69);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(31, 19);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Archivo";
            this.btnExportar.UseVisualStyleBackColor = true;
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
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(133, 55);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaInicio.TabIndex = 7;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(695, 525);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Location = new System.Drawing.Point(673, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
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
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Comisionista",
            "Combo Producto",
            "Canal",
            "Distrito"});
            this.cbCampo.Location = new System.Drawing.Point(152, 135);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 16;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(314, 135);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(134, 20);
            this.tbFiltro.TabIndex = 17;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(487, 135);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(43, 23);
            this.buttonBuscar.TabIndex = 18;
            this.buttonBuscar.Text = "...";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // idOrden
            // 
            this.idOrden.HeaderText = "idOrden";
            this.idOrden.Name = "idOrden";
            // 
            // nombreComisionista
            // 
            this.nombreComisionista.HeaderText = "Comisionista";
            this.nombreComisionista.Name = "nombreComisionista";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Canal
            // 
            this.Canal.HeaderText = "Canal";
            this.Canal.Name = "Canal";
            // 
            // distrito
            // 
            this.distrito.HeaderText = "Distrito";
            this.distrito.Name = "distrito";
            // 
            // MontoVendido
            // 
            this.MontoVendido.HeaderText = "MontoVendido";
            this.MontoVendido.Name = "MontoVendido";
            // 
            // FrmVisualizarRecordVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 623);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
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
            this.Name = "FrmVisualizarRecordVendido";
            this.Text = "Visualizar Record Vendido";
            this.Load += new System.EventHandler(this.VisualizarRecordVendido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.RadioButton rdoMensual;
        private System.Windows.Forms.RadioButton rdoDiario;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComisionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoVendido;
    }
}