namespace Vista
{
    partial class FrmRecuperarOrden
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComisionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIngreseDato = new System.Windows.Forms.Panel();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreseCampo = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.pnlIngreseDato.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(657, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(564, 530);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToOrderColumns = true;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrden,
            this.nombreComisionista,
            this.producto,
            this.Fecha,
            this.Canal,
            this.MontoVendido});
            this.dgvOrden.Location = new System.Drawing.Point(29, 180);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.Size = new System.Drawing.Size(703, 329);
            this.dgvOrden.TabIndex = 6;
            this.dgvOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellContentClick);
            this.dgvOrden.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrden_ColumnHeaderMouseClick);
            // 
            // idOrden
            // 
            this.idOrden.DataPropertyName = "Id";
            this.idOrden.HeaderText = "ID";
            this.idOrden.Name = "idOrden";
            // 
            // nombreComisionista
            // 
            this.nombreComisionista.DataPropertyName = "Trabajador";
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
            // MontoVendido
            // 
            this.MontoVendido.DataPropertyName = "Monto";
            this.MontoVendido.HeaderText = "Monto Vendido";
            this.MontoVendido.Name = "MontoVendido";
            this.MontoVendido.Width = 110;
            // 
            // pnlIngreseDato
            // 
            this.pnlIngreseDato.Controls.Add(this.txtDato);
            this.pnlIngreseDato.Controls.Add(this.label2);
            this.pnlIngreseDato.Location = new System.Drawing.Point(367, 74);
            this.pnlIngreseDato.Name = "pnlIngreseDato";
            this.pnlIngreseDato.Size = new System.Drawing.Size(354, 100);
            this.pnlIngreseDato.TabIndex = 29;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(32, 58);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(278, 20);
            this.txtDato.TabIndex = 1;
            this.txtDato.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDato_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese dato:";
            // 
            // lblIngreseCampo
            // 
            this.lblIngreseCampo.AutoSize = true;
            this.lblIngreseCampo.Location = new System.Drawing.Point(56, 139);
            this.lblIngreseCampo.Name = "lblIngreseCampo";
            this.lblIngreseCampo.Size = new System.Drawing.Size(121, 13);
            this.lblIngreseCampo.TabIndex = 32;
            this.lblIngreseCampo.Text = "Ingrese campo a buscar";
            // 
            // cmbCampo
            // 
            this.cmbCampo.AutoCompleteCustomSource.AddRange(new string[] {
            "idUsuario",
            "Usuario",
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Correo",
            "Jefe Directo"});
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "<Todos>",
            "ID",
            "Comisionista",
            "Producto",
            "Canal"});
            this.cmbCampo.Location = new System.Drawing.Point(222, 136);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 31;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "PAPELERA DE RECICLAJE ORDENES";
            // 
            // FrmRecuperarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIngreseCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.pnlIngreseDato);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "FrmRecuperarOrden";
            this.Text = "Recuperar Orden";
            this.Load += new System.EventHandler(this.FrmRecuperarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.pnlIngreseDato.ResumeLayout(false);
            this.pnlIngreseDato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComisionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoVendido;
        private System.Windows.Forms.Panel pnlIngreseDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreseCampo;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label1;
    }
}