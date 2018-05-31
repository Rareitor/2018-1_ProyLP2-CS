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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(734, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(621, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
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
            this.dgvOrden.Location = new System.Drawing.Point(25, 59);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.Size = new System.Drawing.Size(788, 332);
            this.dgvOrden.TabIndex = 6;
            // 
            // idOrden
            // 
            this.idOrden.DataPropertyName = "Id";
            this.idOrden.HeaderText = "idOrden";
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
            this.MontoVendido.HeaderText = "MontoVendido";
            this.MontoVendido.Name = "MontoVendido";
            // 
            // FrmRecuperarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "FrmRecuperarOrden";
            this.Text = "FrmRecuperarOrden";
            this.Load += new System.EventHandler(this.FrmRecuperarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);

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
    }
}