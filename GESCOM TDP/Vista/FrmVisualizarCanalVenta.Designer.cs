namespace Vista.Otros
{
    partial class FrmVisualizarCanalVenta
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
            this.dgvCanalVenta = new System.Windows.Forms.DataGridView();
            this.lblNombreCanal = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.idCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanalVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCanalVenta
            // 
            this.dgvCanalVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanalVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCanal,
            this.nombre});
            this.dgvCanalVenta.Location = new System.Drawing.Point(26, 101);
            this.dgvCanalVenta.Name = "dgvCanalVenta";
            this.dgvCanalVenta.Size = new System.Drawing.Size(514, 186);
            this.dgvCanalVenta.TabIndex = 1;
            // 
            // lblNombreCanal
            // 
            this.lblNombreCanal.AutoSize = true;
            this.lblNombreCanal.Location = new System.Drawing.Point(23, 32);
            this.lblNombreCanal.Name = "lblNombreCanal";
            this.lblNombreCanal.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCanal.TabIndex = 2;
            this.lblNombreCanal.Text = "Nombre de canal:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(438, 42);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(60, 69);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // idCanal
            // 
            this.idCanal.DataPropertyName = "idCanal";
            this.idCanal.HeaderText = "idCanal";
            this.idCanal.Name = "idCanal";
            this.idCanal.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // FrmVisualizarCanalVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblNombreCanal);
            this.Controls.Add(this.dgvCanalVenta);
            this.Name = "FrmVisualizarCanalVenta";
            this.Text = "Visualizar Canal Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanalVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCanalVenta;
        private System.Windows.Forms.Label lblNombreCanal;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}