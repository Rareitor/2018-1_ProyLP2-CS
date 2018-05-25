namespace Vista
{
    partial class FrmBusquedaOrdenPersonalizada
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMontoRetribucion = new System.Windows.Forms.Label();
            this.cmbIdComisionista = new System.Windows.Forms.ComboBox();
            this.lblIdComisionista = new System.Windows.Forms.Label();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbSimbolo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(146, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 30);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblMontoRetribucion
            // 
            this.lblMontoRetribucion.AutoSize = true;
            this.lblMontoRetribucion.Location = new System.Drawing.Point(13, 141);
            this.lblMontoRetribucion.Name = "lblMontoRetribucion";
            this.lblMontoRetribucion.Size = new System.Drawing.Size(127, 13);
            this.lblMontoRetribucion.TabIndex = 19;
            this.lblMontoRetribucion.Text = "MONTO RETRIBUCIÓN:";
            // 
            // cmbIdComisionista
            // 
            this.cmbIdComisionista.FormattingEnabled = true;
            this.cmbIdComisionista.Location = new System.Drawing.Point(146, 95);
            this.cmbIdComisionista.Name = "cmbIdComisionista";
            this.cmbIdComisionista.Size = new System.Drawing.Size(121, 21);
            this.cmbIdComisionista.TabIndex = 18;
            // 
            // lblIdComisionista
            // 
            this.lblIdComisionista.AutoSize = true;
            this.lblIdComisionista.Location = new System.Drawing.Point(13, 98);
            this.lblIdComisionista.Name = "lblIdComisionista";
            this.lblIdComisionista.Size = new System.Drawing.Size(101, 13);
            this.lblIdComisionista.TabIndex = 17;
            this.lblIdComisionista.Text = "ID COMISIONISTA:";
            // 
            // cmbCanal
            // 
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(146, 56);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(121, 21);
            this.cmbCanal.TabIndex = 16;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(12, 59);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(45, 13);
            this.lblCanal.TabIndex = 15;
            this.lblCanal.Text = "CANAL:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "FECHA:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(207, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 22;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(207, 134);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 23;
            // 
            // cmbSimbolo
            // 
            this.cmbSimbolo.FormattingEnabled = true;
            this.cmbSimbolo.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cmbSimbolo.Location = new System.Drawing.Point(146, 133);
            this.cmbSimbolo.Name = "cmbSimbolo";
            this.cmbSimbolo.Size = new System.Drawing.Size(41, 21);
            this.cmbSimbolo.TabIndex = 24;
            this.cmbSimbolo.SelectedIndexChanged += new System.EventHandler(this.cmbSimbolo_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.comboBox1.Location = new System.Drawing.Point(146, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // FrmBusquedaOrdenPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 217);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbSimbolo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMontoRetribucion);
            this.Controls.Add(this.cmbIdComisionista);
            this.Controls.Add(this.lblIdComisionista);
            this.Controls.Add(this.cmbCanal);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblFecha);
            this.Name = "FrmBusquedaOrdenPersonalizada";
            this.Text = "Búsqueda de Orden Personalizada";
            this.Load += new System.EventHandler(this.FrmBusquedaOrdenPersonalizada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMontoRetribucion;
        private System.Windows.Forms.ComboBox cmbIdComisionista;
        private System.Windows.Forms.Label lblIdComisionista;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbSimbolo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}