namespace Vista.Otros
{
    partial class FrmGestionarOrdenAdmin
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
            this.btnAnadir = new System.Windows.Forms.Button();
            this.lblMontoRetribucion = new System.Windows.Forms.TextBox();
            this.txtMontoRetribucion = new System.Windows.Forms.Label();
            this.txtIdComisionista = new System.Windows.Forms.TextBox();
            this.lblIdComisionista = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtIdOrden = new System.Windows.Forms.TextBox();
            this.lblIdOrden = new System.Windows.Forms.Label();
            this.btnBuscarComisionista = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMonto = new System.Windows.Forms.ComboBox();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.chkIdOrden = new System.Windows.Forms.CheckBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.chkComisionista = new System.Windows.Forms.CheckBox();
            this.chkMonto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(184, 173);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 26;
            this.btnAnadir.Text = "Buscar";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMontoRetribucion
            // 
            this.lblMontoRetribucion.Enabled = false;
            this.lblMontoRetribucion.Location = new System.Drawing.Point(248, 141);
            this.lblMontoRetribucion.Name = "lblMontoRetribucion";
            this.lblMontoRetribucion.Size = new System.Drawing.Size(191, 20);
            this.lblMontoRetribucion.TabIndex = 23;
            this.lblMontoRetribucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblMontoRetribucion_KeyPress);
            // 
            // txtMontoRetribucion
            // 
            this.txtMontoRetribucion.AutoSize = true;
            this.txtMontoRetribucion.Location = new System.Drawing.Point(33, 140);
            this.txtMontoRetribucion.Name = "txtMontoRetribucion";
            this.txtMontoRetribucion.Size = new System.Drawing.Size(94, 13);
            this.txtMontoRetribucion.TabIndex = 22;
            this.txtMontoRetribucion.Text = "Monto Retribución";
            // 
            // txtIdComisionista
            // 
            this.txtIdComisionista.Location = new System.Drawing.Point(202, 96);
            this.txtIdComisionista.Name = "txtIdComisionista";
            this.txtIdComisionista.ReadOnly = true;
            this.txtIdComisionista.Size = new System.Drawing.Size(206, 20);
            this.txtIdComisionista.TabIndex = 21;
            // 
            // lblIdComisionista
            // 
            this.lblIdComisionista.AutoSize = true;
            this.lblIdComisionista.Location = new System.Drawing.Point(33, 96);
            this.lblIdComisionista.Name = "lblIdComisionista";
            this.lblIdComisionista.Size = new System.Drawing.Size(77, 13);
            this.lblIdComisionista.TabIndex = 20;
            this.lblIdComisionista.Text = "Id Comisionista";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(33, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdOrden
            // 
            this.txtIdOrden.Enabled = false;
            this.txtIdOrden.Location = new System.Drawing.Point(202, 18);
            this.txtIdOrden.Name = "txtIdOrden";
            this.txtIdOrden.Size = new System.Drawing.Size(237, 20);
            this.txtIdOrden.TabIndex = 15;
            // 
            // lblIdOrden
            // 
            this.lblIdOrden.AutoSize = true;
            this.lblIdOrden.Location = new System.Drawing.Point(32, 21);
            this.lblIdOrden.Name = "lblIdOrden";
            this.lblIdOrden.Size = new System.Drawing.Size(48, 13);
            this.lblIdOrden.TabIndex = 14;
            this.lblIdOrden.Text = "Id Orden";
            this.lblIdOrden.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarComisionista
            // 
            this.btnBuscarComisionista.Enabled = false;
            this.btnBuscarComisionista.Location = new System.Drawing.Point(414, 96);
            this.btnBuscarComisionista.Name = "btnBuscarComisionista";
            this.btnBuscarComisionista.Size = new System.Drawing.Size(25, 20);
            this.btnBuscarComisionista.TabIndex = 28;
            this.btnBuscarComisionista.Text = "...";
            this.btnBuscarComisionista.UseVisualStyleBackColor = true;
            this.btnBuscarComisionista.Click += new System.EventHandler(this.btnBuscarComisionista_Click_1);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(248, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(191, 20);
            this.dtpFecha.TabIndex = 30;
            // 
            // cmbMonto
            // 
            this.cmbMonto.Enabled = false;
            this.cmbMonto.FormattingEnabled = true;
            this.cmbMonto.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbMonto.Location = new System.Drawing.Point(202, 140);
            this.cmbMonto.Name = "cmbMonto";
            this.cmbMonto.Size = new System.Drawing.Size(40, 21);
            this.cmbMonto.TabIndex = 31;
            // 
            // cmbFecha
            // 
            this.cmbFecha.Enabled = false;
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbFecha.Location = new System.Drawing.Point(202, 59);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(40, 21);
            this.cmbFecha.TabIndex = 32;
            // 
            // chkIdOrden
            // 
            this.chkIdOrden.AutoSize = true;
            this.chkIdOrden.Location = new System.Drawing.Point(163, 20);
            this.chkIdOrden.Name = "chkIdOrden";
            this.chkIdOrden.Size = new System.Drawing.Size(15, 14);
            this.chkIdOrden.TabIndex = 33;
            this.chkIdOrden.UseVisualStyleBackColor = true;
            this.chkIdOrden.CheckedChanged += new System.EventHandler(this.chkIdOrden_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(163, 66);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 34;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkComisionista
            // 
            this.chkComisionista.AutoSize = true;
            this.chkComisionista.Location = new System.Drawing.Point(163, 102);
            this.chkComisionista.Name = "chkComisionista";
            this.chkComisionista.Size = new System.Drawing.Size(15, 14);
            this.chkComisionista.TabIndex = 35;
            this.chkComisionista.UseVisualStyleBackColor = true;
            this.chkComisionista.CheckedChanged += new System.EventHandler(this.chkComisionista_CheckedChanged);
            // 
            // chkMonto
            // 
            this.chkMonto.AutoSize = true;
            this.chkMonto.Location = new System.Drawing.Point(163, 143);
            this.chkMonto.Name = "chkMonto";
            this.chkMonto.Size = new System.Drawing.Size(15, 14);
            this.chkMonto.TabIndex = 36;
            this.chkMonto.UseVisualStyleBackColor = true;
            this.chkMonto.CheckedChanged += new System.EventHandler(this.chkMonto_CheckedChanged);
            // 
            // FrmGestionarOrdenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 208);
            this.Controls.Add(this.chkMonto);
            this.Controls.Add(this.chkComisionista);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.chkIdOrden);
            this.Controls.Add(this.cmbFecha);
            this.Controls.Add(this.cmbMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnBuscarComisionista);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.lblMontoRetribucion);
            this.Controls.Add(this.txtMontoRetribucion);
            this.Controls.Add(this.txtIdComisionista);
            this.Controls.Add(this.lblIdComisionista);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIdOrden);
            this.Controls.Add(this.lblIdOrden);
            this.Name = "FrmGestionarOrdenAdmin";
            this.Text = "Gestionar Orden";
            this.Load += new System.EventHandler(this.GestionarOrdenAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox lblMontoRetribucion;
        private System.Windows.Forms.Label txtMontoRetribucion;
        private System.Windows.Forms.TextBox txtIdComisionista;
        private System.Windows.Forms.Label lblIdComisionista;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtIdOrden;
        private System.Windows.Forms.Label lblIdOrden;
        private System.Windows.Forms.Button btnBuscarComisionista;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbMonto;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.CheckBox chkIdOrden;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.CheckBox chkComisionista;
        private System.Windows.Forms.CheckBox chkMonto;
    }
}